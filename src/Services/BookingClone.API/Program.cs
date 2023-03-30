using System.Reflection;
using System.Text.Json.Serialization;
using System.Threading.RateLimiting;
<<<<<<< HEAD

using Asp.Versioning;

=======
using Asp.Versioning;
>>>>>>> first commit
using BookingClone.API.Authentication;
using BookingClone.API.Extensions;
using BookingClone.API.OpenApi;
using BookingClone.Application;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Data;
using BookingClone.Infrastructure.Repositories;
using BookingClone.Serilog;
<<<<<<< HEAD

=======
>>>>>>> first commit
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
<<<<<<< HEAD

using Serilog;

=======
using Serilog;
>>>>>>> first commit
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.AddServerHeader = false;
    options.ConfigureHttpsDefaults(s => s.AllowAnyClientCertificate());
    options.ConfigureEndpointDefaults(o => o.Protocols = HttpProtocols.Http1AndHttp2AndHttp3);
});

builder.Host.UseSerilog(Serilogger.Configure);

// Add services to the container.

<<<<<<< HEAD
builder.Services.AddApplicationServices(builder.Configuration);
=======
builder.Services.AddDbContext<BookingDbContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"), c =>
        c.EnableRetryOnFailure(3))
);

<<<<<<< HEAD
builder.Services.AddApplicationServices();
>>>>>>> first commit
=======
//builder.Services.AddApplicationServices();
builder.Services.AddApplicationServices(builder.Configuration);
>>>>>>> salmateest

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
<<<<<<< HEAD

<<<<<<< HEAD

=======
>>>>>>> first commit
=======
builder.Services.AddScoped<ICityRepository,CityRepository > ();
builder.Services.AddScoped<IContinentRepository, ContinentRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
>>>>>>> add city and country and continent
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

builder.Services.AddControllers()
    .AddJsonOptions(o => o.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault);
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

    var requirement = new OpenApiSecurityRequirement
    {
        { scheme, Array.Empty<string>() }
    };

    o.AddSecurityRequirement(requirement);

    string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    o.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsStaging() || app.Environment.IsEnvironment("DockerDevelopment"))
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

<<<<<<< HEAD
<<<<<<< HEAD
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseAuthorization();
=======
app.UseMiddleware<ApiKeyAuthMiddleware>();
=======
//app.UseMiddleware<ApiKeyAuthMiddleware>();
>>>>>>> api(country_continent_city)
app.UseAuthorization();

>>>>>>> first commit
app.UseRateLimiter();

app.MapControllers();
app.MapCustomHealthChecks();

<<<<<<< HEAD
app.Run();
=======
app.Run();
>>>>>>> first commit
