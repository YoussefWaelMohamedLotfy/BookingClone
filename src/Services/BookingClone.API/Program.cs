using System.Reflection;
using System.Threading.RateLimiting;
using Asp.Versioning;
using BookingClone.API.Authentication;
using BookingClone.API.Extensions;
using BookingClone.API.OpenApi;
using BookingClone.Application;
using BookingClone.Infrastructure.Data;
using BookingClone.Serilog;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;

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

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApiVersioning(o =>
{
    o.DefaultApiVersion = new(1, 0);
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.UnsupportedApiVersionStatusCode = 501;
    o.ReportApiVersions = true;
    o.ApiVersionReader = ApiVersionReader.Combine(
            new HeaderApiVersionReader("X-api-version"),
            new MediaTypeApiVersionReader()
        );
})
    .AddApiExplorer(o => o.SubstituteApiVersionInUrl = true);

builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

builder.Services.AddControllers();
builder.Services.AddScoped<ApiKeyAuthFilter>();

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
    o.OperationFilter<SwaggerDefaultValues>();

    o.AddSecurityDefinition("ApiKey", new()
    {
        Name = "x-api-key",
        Description = "The API Key to Authorize",
        Type = SecuritySchemeType.ApiKey,
        In = ParameterLocation.Header,
        Scheme = "ApiKeyScheme"
    });

    var scheme = new OpenApiSecurityScheme
    {
        Reference = new()
        {
            Id = "ApiKey",
            Type = ReferenceType.SecurityScheme
        },
        In = ParameterLocation.Header
    };

    var requirment = new OpenApiSecurityRequirement
    {
        { scheme, Array.Empty<string>() }
    };

    o.AddSecurityRequirement(requirment);

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
    app.UseSwaggerUI(o =>
    {
        foreach (var item in app.DescribeApiVersions())
        {
            string url = $"/swagger/{item.GroupName}/swagger.json";
            o.SwaggerEndpoint(url, item.GroupName.ToUpperInvariant());
        }
    });
}

app.UseHttpsRedirection();

app.UseMiddleware<ApiKeyAuthMiddleware>();
app.UseAuthorization();

app.UseRateLimiter();

app.MapControllers();
app.MapCustomHealthChecks();

app.Run();
