using System.Reflection;
using System.Threading.RateLimiting;
using BookingClone.API.Extensions;
using BookingClone.Application;
using BookingClone.Infrastructure.Data;
using BookingClone.Serilog;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog(Serilogger.Configure);

// Add services to the container.

builder.Services.AddApplicationServices();

builder.Services.AddDbContext<BookingDbContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"));
});

//builder.Services.AddStackExchangeRedisCache(o =>
//{
//    o.Configuration = builder.Configuration.GetConnectionString("RedisConnection");
//    //o.ConfigurationOptions = new() { AbortOnConnectFail = false };
//});

builder.Services.AddControllers();

builder.Services.AddRateLimiter(options =>
{
    options.OnRejected = async (context, token) =>
    {
        context.HttpContext.Response.StatusCode = 429;

        if (context.Lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
        {
            await context.HttpContext.Response.WriteAsync($"Too many requests. Please try again after {retryAfter.TotalSeconds} seconds.", token);
        }
        else
        {
            await context.HttpContext.Response.WriteAsync("Too many requests. Please try again later.", token);
        }
    };

    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
        RateLimitPartition.GetFixedWindowLimiter(
            partitionKey: httpContext.User.Identity?.Name ?? httpContext.Request.Headers.Host.ToString(),
            factory: partition => new FixedWindowRateLimiterOptions
            {
                AutoReplenishment = true,
                PermitLimit = 30,
                QueueLimit = 0,
                Window = TimeSpan.FromMinutes(1)
            }));
});

builder.Services.AddHealthChecks()
    .AddSqlServer(
        builder.Configuration.GetConnectionString("SqlServerConnection")!,
        name: "SQL Server Connection Check",
        failureStatus: HealthStatus.Degraded,
        tags: new[] { "ready" })
    //.AddRedis(
    //    builder.Configuration.GetConnectionString("RedisConnection")!,
    //    name: "Redis Cache Connection Check",
    //    failureStatus: HealthStatus.Degraded,
    //    tags: new[] { "ready" })
    .AddDbContextCheck<BookingDbContext>(
        "BookingDbContext EF Core Check",
        failureStatus: HealthStatus.Degraded,
        tags: new[] { "ready" })
    .AddUrlGroup(
        new Uri("https://www.google.com"),
        name: "External URL Check",
        failureStatus: HealthStatus.Degraded,
        timeout: TimeSpan.FromSeconds(10),
        tags: new[] { "live" });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o =>
{
    string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    o.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.MigrateDatabase<BookingDbContext>((context, services)
        => context.Seed(services.GetRequiredService<ILogger<BookingDbContext>>()));

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRateLimiter();

app.MapControllers();
app.MapCustomHealthChecks();

app.Run();
