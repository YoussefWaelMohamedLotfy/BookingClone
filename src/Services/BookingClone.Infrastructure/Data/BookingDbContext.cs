﻿using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Conventions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookingClone.Infrastructure.Data;

public sealed class BookingDbContext : DbContext
{
<<<<<<< HEAD
   
    public BookingDbContext(DbContextOptions options) : base(options)
    {


    }



=======
    public BookingDbContext(DbContextOptions options) : base(options)
    {
    }

>>>>>>> first commit
    public DbSet<Attraction> Attractions { get; set; }
    public DbSet<AttractionImage> AttractionImages { get; set; }
    public DbSet<AttractionReservation> AttractionReservations { get; set; }
    public DbSet<AttractionReview> AttractionReviews { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<CityHotel> CityHotels { get; set; }
    public DbSet<Continent> Continents { get; set; }
    public DbSet<City> Countries { get; set; }
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
        foreach (var property in modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => (Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal)))
        {
            property.SetPrecision(18);
            property.SetScale(2);
        }

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new StringMaxLengthConvention(90));
        base.ConfigureConventions(configurationBuilder);
    }
<<<<<<< HEAD
<<<<<<< HEAD


=======
>>>>>>> first commit
=======

    //protected override void OnConfiguring(DbContextOptionsBuilder DbContextOptionsBuilder)
    //{
    //    DbContextOptionsBuilder.UseSqlServer("Data Source=DESKTOP-P73CSRJ\\SQLEXPRESS;Database=BookingClone;Integrated Security=True;Connect Timeout=30;Encrypt=False") ;
    //}

>>>>>>> add city and country and continent
}
