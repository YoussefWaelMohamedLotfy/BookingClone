using Bogus;
using BookingClone.Domain.Entities;
using BookingClone.Domain.Enums;
using Microsoft.Extensions.Logging;

namespace BookingClone.Infrastructure.Data;

public static class BookingDbContextExtensions
{
    public static void Seed(this BookingDbContext context, ILogger<BookingDbContext> logger)
    {
        if (!context.Hotels.Any())
        {
            var hotelsFaker = new Faker<Hotel>()
                .RuleFor(h => h.Name, f => f.Company.CompanyName())
                .RuleFor(h => h.Description, f => f.Company.CatchPhrase());

            context.Hotels.AddRange(hotelsFaker.Generate(20));
            context.SaveChanges();
        }

        if (!context.AttractionReservations.Any())
        {
            var attractionReservationsFaker = new Faker<AttractionReservation>()
                .RuleFor(ar => ar.TotalCost, f => f.Random.Decimal(500, 5000))
                .RuleFor(ar => ar.Status, f => f.Random.Enum<ReservationStatus>())
                .RuleFor(ar => ar.TourStart, f => f.Date.SoonOffset());

            context.AttractionReservations.AddRange(attractionReservationsFaker.Generate(20));
            context.SaveChanges();
        }

        if (!context.RoomReservations.Any())
        {
            var roomReservationsFaker = new Faker<RoomReservation>()
                .RuleFor(ar => ar.TotalCost, f => f.Random.Decimal(500, 5000))
                .RuleFor(ar => ar.Status, f => f.Random.Enum<ReservationStatus>())
                .RuleFor(ar => ar.CheckIn, f => f.Date.SoonOffset())
                .RuleFor(ar => ar.CheckOut, f => f.Date.FutureOffset());

            context.RoomReservations.AddRange(roomReservationsFaker.Generate(20));
            context.SaveChanges();
        }

        logger.LogInformation("Completed Seeding of context.");
    }
}