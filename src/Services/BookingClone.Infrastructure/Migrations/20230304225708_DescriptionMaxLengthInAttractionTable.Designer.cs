﻿// <auto-generated />
using System;
using BookingClone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingClone.Infrastructure.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    [Migration("20230304225708_DescriptionMaxLengthInAttractionTable")]
    partial class DescriptionMaxLengthInAttractionTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("ReservationSequence");

            modelBuilder.HasSequence("ReviewSequence");

            modelBuilder.Entity("BookingClone.Domain.Entities.Attraction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AvailableTickets")
                        .HasColumnType("int");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<decimal>("TicketPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.HasKey("ID");

                    b.HasIndex("CountryID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.CityHotel", b =>
                {
                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.HasKey("CityID", "HotelID");

                    b.HasIndex("HotelID");

                    b.ToTable("CityHotels");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Continent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.HasKey("ID");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContinentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.HasKey("ID");

                    b.HasIndex("ContinentID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<decimal>("StarRating")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [ReservationSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("ID"));

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.ReservedAttraction", b =>
                {
                    b.Property<int>("AttractionID")
                        .HasColumnType("int");

                    b.Property<int>("AttractionReservationID")
                        .HasColumnType("int");

                    b.Property<int>("TicketCount")
                        .HasColumnType("int");

                    b.HasKey("AttractionID", "AttractionReservationID");

                    b.HasIndex("AttractionReservationID");

                    b.ToTable("ReservedAttractions");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.ReservedRoom", b =>
                {
                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("RoomReservationID")
                        .HasColumnType("int");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.HasKey("RoomID", "RoomReservationID");

                    b.HasIndex("RoomReservationID");

                    b.ToTable("ReservedRooms");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [ReviewSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("ID"));

                    b.Property<DateTimeOffset>("ReviewDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ID");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<int>("ViewType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HotelID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.AttractionReservation", b =>
                {
                    b.HasBaseType("BookingClone.Domain.Entities.Reservation");

                    b.Property<DateTimeOffset>("TourStart")
                        .HasColumnType("datetimeoffset");

                    b.ToTable("AttractionReservations");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.RoomReservation", b =>
                {
                    b.HasBaseType("BookingClone.Domain.Entities.Reservation");

                    b.Property<DateTimeOffset>("CheckIn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("CheckOut")
                        .HasColumnType("datetimeoffset");

                    b.ToTable("RoomReservations");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.AttractionReview", b =>
                {
                    b.HasBaseType("BookingClone.Domain.Entities.Review");

                    b.Property<int>("AttractionID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.HasIndex("AttractionID");

                    b.ToTable("AttractionReviews");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.HotelReview", b =>
                {
                    b.HasBaseType("BookingClone.Domain.Entities.Review");

                    b.Property<decimal>("CleanlinessRate")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ComfortRate")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FacilitiesRate")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<decimal>("LocationRate")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NegativeReview")
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("PositiveReview")
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<decimal>("StaffRate")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValueForMoneyRate")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasIndex("HotelID");

                    b.ToTable("HotelReviews");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Attraction", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.City", "City")
                        .WithMany("Attractions")
                        .HasForeignKey("CityID");

                    b.Navigation("City");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.City", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.CityHotel", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.City", "City")
                        .WithMany("CityHotels")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingClone.Domain.Entities.Hotel", "Hotel")
                        .WithMany("CityHotels")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Country", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.ReservedAttraction", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.Attraction", "Attraction")
                        .WithMany("ReservedAttractions")
                        .HasForeignKey("AttractionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingClone.Domain.Entities.AttractionReservation", "AttractionReservation")
                        .WithMany("ReservedAttractions")
                        .HasForeignKey("AttractionReservationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attraction");

                    b.Navigation("AttractionReservation");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.ReservedRoom", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.Room", "Room")
                        .WithMany("ReservedRooms")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingClone.Domain.Entities.RoomReservation", "RoomReservation")
                        .WithMany("ReservedRooms")
                        .HasForeignKey("RoomReservationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("RoomReservation");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Room", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.AttractionReview", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.Attraction", "Attraction")
                        .WithMany("Reviews")
                        .HasForeignKey("AttractionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attraction");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.HotelReview", b =>
                {
                    b.HasOne("BookingClone.Domain.Entities.Hotel", "Hotel")
                        .WithMany("Reviews")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Attraction", b =>
                {
                    b.Navigation("ReservedAttractions");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.City", b =>
                {
                    b.Navigation("Attractions");

                    b.Navigation("CityHotels");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Hotel", b =>
                {
                    b.Navigation("CityHotels");

                    b.Navigation("Reviews");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.Room", b =>
                {
                    b.Navigation("ReservedRooms");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.AttractionReservation", b =>
                {
                    b.Navigation("ReservedAttractions");
                });

            modelBuilder.Entity("BookingClone.Domain.Entities.RoomReservation", b =>
                {
                    b.Navigation("ReservedRooms");
                });
#pragma warning restore 612, 618
        }
    }
}
