using BookingClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookingClone.Infrastructure.Data;

public sealed class BookingDbContext : DbContext
{
    public BookingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Attraction> Attractions { get; set; }
    public DbSet<AttractionReservation> AttractionReservations { get; set; }
    public DbSet<AttractionReview> AttractionReviews { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<CityHotel> CityHotels { get; set; }
    public DbSet<Continent> Continents { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<HotelReview> HotelReviews { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<ReservedAttraction> ReservedAttractions { get; set; }
    public DbSet<ReservedRoom> ReservedRooms { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomReservation> RoomReservations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CityHotel>()
            .HasKey(ch => new { ch.CityID, ch.HotelID });

        modelBuilder.Entity<ReservedAttraction>()
            .HasKey(ra => new { ra.AttractionID, ra.AttractionReservationID });

        modelBuilder.Entity<ReservedRoom>()
            .HasKey(rr => new { rr.RoomID, rr.RoomReservationID });

        base.OnModelCreating(modelBuilder);
    }
}
