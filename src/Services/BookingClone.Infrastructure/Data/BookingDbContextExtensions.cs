using Bogus;
using BookingClone.Domain.Entities;
using BookingClone.Domain.Enums;
using Microsoft.Extensions.Logging;

namespace BookingClone.Infrastructure.Data;

public static class BookingDbContextExtensions
{
    public static void Seed(this BookingDbContext context, ILogger<BookingDbContext> logger)
    {
        if (!context.Continents.Any())
        {
            context.Continents.AddRange(new[]
            {
                new Continent { Name = "Africa" },
                new Continent { Name = "Asia" },
                new Continent { Name = "Europe" },
                new Continent { Name = "Australia" },
                new Continent { Name = "South America" },
                new Continent { Name = "North America" },
                new Continent { Name = "Antarcatica" },
            });
            context.SaveChanges();
        }

        if (!context.Countries.Any())
        {
            context.Countries.AddRange(new[]
            {
                new Country { Name = "Egypt", ContinentID = 1 },
                new Country { Name = "Algeria", ContinentID = 1 },
                new Country { Name = "Angola", ContinentID = 1 },
                new Country { Name = "Austria", ContinentID = 3 },
                new Country { Name = "Belarus", ContinentID = 2 },
                new Country { Name = "Palestine", ContinentID = 2 },
                new Country { Name = "China", ContinentID = 2 },
                new Country { Name = "France", ContinentID = 3 },
                new Country { Name = "Gaban", ContinentID = 1 },
                new Country { Name = "Greece", ContinentID = 3 },
                new Country { Name = "Iceland", ContinentID = 3 },
                new Country { Name = "India", ContinentID = 2 },
                new Country { Name = "Iran", ContinentID = 2 },
                new Country { Name = "Italy", ContinentID = 3 },
                new Country { Name = "Japan", ContinentID = 2 },
                new Country { Name = "Jordan", ContinentID = 2 },
                new Country { Name = "Korea", ContinentID = 2 },
                new Country { Name = "Libya", ContinentID = 1 },
                new Country { Name = "Niger", ContinentID = 1 },
                new Country { Name = "Qater", ContinentID = 2 },
                new Country { Name = "Vienna", ContinentID = 3 },
                new Country { Name = "Chile", ContinentID = 1 },
            });
            context.SaveChanges();
        }

        if (!context.Cities.Any())
        {
            context.Cities.AddRange(new[]
            {
                new City { Name = "Cairo", CountryID = 1 },
                new City { Name = "Nassau", CountryID = 1 },
                new City { Name = "Baku", CountryID = 1 },
                new City { Name = "la paz", CountryID = 1 },
                new City { Name = "Sofia", CountryID = 1 },
                new City { Name = "Praia", CountryID = 1 },
                new City { Name = "Dili", CountryID = 1 },
                new City { Name = "Asmara", CountryID = 1 },
                new City { Name = "Conakry", CountryID = 1 },
                new City { Name = "Tokyo", CountryID = 1 },
                new City { Name = "Lisban", CountryID = 1 },
                new City { Name = "Apia", CountryID = 1 },
                new City { Name = "Sanaa", CountryID = 1 },
                new City { Name = "Downtown", CountryID = 1 },
                new City { Name = "Torino", CountryID = 1 },
                new City { Name = "Milano", CountryID = 1 },
                new City { Name = "Roma", CountryID = 1 },
                new City { Name = "Soul", CountryID = 1 },
                new City { Name = "Sirte", CountryID = 1 },
                new City { Name = "Baku", CountryID = 1 },
                new City { Name = "Nassau", CountryID = 1 },
                new City { Name = "Paria", CountryID = 1 },
                new City { Name = "Suva", CountryID = 1 },
                new City { Name = "Riga", CountryID = 1 },
                new City { Name = "Giza", CountryID = 1 },
                new City { Name = "Alexandria", CountryID = 1 },
                new City { Name = "Sohag", CountryID = 1 },
                new City { Name = "Qena", CountryID = 1 },
                new City { Name = "Matareya", CountryID = 1 },
                new City { Name = "Al-mansura", CountryID = 1 },
                new City { Name = "Tanta", CountryID = 1 },
                new City { Name = "Asyut", CountryID = 1 },
                new City { Name = "Jabalia", CountryID = 1 },
                new City { Name = "Gaza", CountryID = 1 },
                new City { Name = "Paris", CountryID = 1 },
                new City { Name = "taloq", CountryID = 1 },
                new City { Name = "Chad", CountryID = 1 },
            });
            context.SaveChanges();
        }

        if (!context.Hotels.Any())
        {
            var hotelsFaker = new Faker<Hotel>()
                .RuleFor(h => h.Name, f => f.Company.CompanyName())
                .RuleFor(h => h.Description, f => f.Company.CatchPhrase());

            context.Hotels.AddRange(hotelsFaker.Generate(20));
            context.SaveChanges();
        }

        if (!context.Rooms.Any())
        {
            var roomsFaker = new Faker<Room>()
                .RuleFor(h => h.RoomNumber, f => f.Company.CompanyName())
                .RuleFor(h => h.Description, f => f.Company.CatchPhrase())
                .RuleFor(h => h.BedCount, f => f.Random.Number(1, 3))
                .RuleFor(h => h.Price, f => f.Random.Decimal(100, 1000))
                .RuleFor(h => h.ViewType, f => f.Random.Enum<RoomViewType>())
                .RuleFor(h => h.IsAvailable, f => f.Random.Bool(0.7f))
                .RuleFor(h => h.HotelId, f => f.Random.Number(1, 20));

            context.Rooms.AddRange(roomsFaker.Generate(20));
            context.SaveChanges();
        }

        if (!context.Attractions.Any()) 
        {
            var attractionsFaker = new Faker<Attraction>()
                .RuleFor(a => a.Name, f => f.Commerce.ProductName())
                .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
                .RuleFor(a => a.AvailableTickets, f => f.Random.Int(1, 100))
                .RuleFor(a => a.TicketPrice, f => f.Random.Decimal(50, 500))
                .RuleFor(a => a.Duration, f => f.Date.FutureOffset().ToString());

            context.Attractions.AddRange(attractionsFaker.Generate(20));
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

        if (!context.AttractionReviews.Any())
        {
            var attractionReviewsFaker = new Faker<AttractionReview>()
                .RuleFor(ar => ar.Comment, f => f.Lorem.Sentence())
                .RuleFor(ar => ar.AttractionID, f => f.Random.Number(1, 20))
                .RuleFor(ar => ar.ReviewDate, f => f.Date.RecentOffset());

            context.AttractionReviews.AddRange(attractionReviewsFaker.Generate(20));
            context.SaveChanges();
        }

        if (!context.HotelReviews.Any())
        {
            var hotelReviewsFaker = new Faker<HotelReview>()
                .RuleFor(ar => ar.HotelID, f => f.Random.Number(1, 20))
                .RuleFor(ar => ar.LocationRate, f => f.Random.Decimal(1, 10))
                .RuleFor(ar => ar.CleanlinessRate, f => f.Random.Decimal(1, 10))
                .RuleFor(ar => ar.StaffRate, f => f.Random.Decimal(1, 10))
                .RuleFor(ar => ar.ComfortRate, f => f.Random.Decimal(1, 10))
                .RuleFor(ar => ar.FacilitiesRate, f => f.Random.Decimal(1, 10))
                .RuleFor(ar => ar.StaffRate, f => f.Random.Decimal(1, 10))
                .RuleFor(ar => ar.ValueForMoneyRate, f => f.Random.Decimal(1, 10))
                .RuleFor(ar => ar.NegativeReview, f => f.Lorem.Sentence())
                .RuleFor(ar => ar.PositiveReview, f => f.Lorem.Sentence())
                .RuleFor(ar => ar.ReviewDate, f => f.Date.RecentOffset());

            context.HotelReviews.AddRange(hotelReviewsFaker.Generate(20));
            context.SaveChanges();
        }

        logger.LogInformation("Completed Seeding of context.");
    }
}