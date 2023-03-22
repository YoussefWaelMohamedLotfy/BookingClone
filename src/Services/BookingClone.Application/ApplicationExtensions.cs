using BookingClone.Domain.Contracts;
<<<<<<< HEAD
using BookingClone.Infrastructure.Data;
using BookingClone.Infrastructure.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
=======
using BookingClone.Infrastructure.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
>>>>>>> first commit
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BookingClone.Application;

public static class ApplicationExtensions
{
<<<<<<< HEAD
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BookingDbContext>(o =>
        o.UseSqlServer(configuration.GetConnectionString("SqlServerConnection"), c =>
            c.EnableRetryOnFailure(3)));

=======
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
>>>>>>> first commit
        services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddFluentValidationAutoValidation()
            .AddFluentValidationClientsideAdapters()
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddScoped<IRoomReservationRepository, RoomReservationRepository>()
            .AddScoped<IAttractionReservationRepository, AttractionReservationRepository>()
<<<<<<< HEAD
            .AddScoped<IAttractionRepository, AttractionRepository>()
            .AddScoped<IRoomRepository, RoomRepository>()
            .AddScoped<IHotelRepository, HotelRepository>()
            .AddScoped<ICityRepository, CityRepository>()
            .AddScoped<IContinentRepository, ContinentRepository>()
            .AddScoped<ICountryRepository, CountryRepository>()
            .AddScoped<IHotelReviewRepository, HotelReviewRepository>()
            .AddScoped<IAttractionReviewRepository, AttractionReviewRepository>();

        return services;
    }
}
=======
            .AddScoped<IAttractionRepository, AttractionRepository>();

        return services;
    }
}
>>>>>>> first commit
