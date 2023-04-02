using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Data;
using BookingClone.Infrastructure.Repositories;

using FluentValidation;
using FluentValidation.AspNetCore;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System.Reflection;


public static class ApplicationExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration  )
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddFluentValidationAutoValidation()
            .AddFluentValidationClientsideAdapters()
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddScoped<IRoomReservationRepository, RoomReservationRepository>()
            .AddScoped<IAttractionReservationRepository, AttractionReservationRepository>()
            .AddScoped<IAttractionRepository, AttractionRepository>()
            .AddScoped<IHotelReviewRepository, HotelReviewRepository>()
            .AddScoped<IAttractionReviewRepository, AttractionReviewRepository>();

        return services;
    }
}
