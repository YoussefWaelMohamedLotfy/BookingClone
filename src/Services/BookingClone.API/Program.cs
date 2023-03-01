using BookingClone.API.Extensions;
using BookingClone.Application;
using BookingClone.Infrastructure.Data;
using BookingClone.Serilog;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog(Serilogger.Configure);

// Add services to the container.

builder.Services.AddApplicationServices();

builder.Services.AddDbContext<BookingDbContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"));
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.MigrateDatabase<BookingDbContext>((context, services) =>
    {
        context.Seed(services.GetRequiredService<ILogger<BookingDbContext>>());
    });

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
