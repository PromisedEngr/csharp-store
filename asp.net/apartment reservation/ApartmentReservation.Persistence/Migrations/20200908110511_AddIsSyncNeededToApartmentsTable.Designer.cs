﻿// <auto-generated />
using System;
using ApartmentReservation.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApartmentReservation.Persistence.Migrations
{
    [DbContext(typeof(ApartmentReservationDbContext))]
    [Migration("20200908110511_AddIsSyncNeededToApartmentsTable")]
    partial class AddIsSyncNeededToApartmentsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired();

                    b.Property<string>("CountryName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PostalCode")
                        .IsRequired();

                    b.Property<string>("StreetName")
                        .IsRequired();

                    b.Property<string>("StreetNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Administrator", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("UserId");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Amenity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Apartment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityState");

                    b.Property<string>("ApartmentType");

                    b.Property<string>("CheckInTime");

                    b.Property<string>("CheckOutTime");

                    b.Property<long?>("GuestUserId");

                    b.Property<long?>("HostId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSyncNeeded")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<long?>("LocationId");

                    b.Property<int>("NumberOfGuests");

                    b.Property<int>("NumberOfRooms");

                    b.Property<double>("PricePerNight");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("GuestUserId");

                    b.HasIndex("HostId");

                    b.HasIndex("LocationId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.ApartmentAmenity", b =>
                {
                    b.Property<long>("ApartmentId");

                    b.Property<long>("AmenityId");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("ApartmentId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.ToTable("ApartmentAmenities");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ApartmentId");

                    b.Property<bool>("Approved");

                    b.Property<long?>("GuestId");

                    b.Property<bool>("IsDeleted");

                    b.Property<byte>("Rating");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("GuestId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.ForRentalDate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ApartmentId");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("ForRentalDates");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Guest", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("UserId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Host", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("UserId");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Image", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ApartmentId");

                    b.Property<string>("ImageUri")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AddressId");

                    b.Property<bool>("IsDeleted");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Reservation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ApartmentId");

                    b.Property<long?>("GuestId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSyncNeeded")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<int>("NumberOfNightsRented");

                    b.Property<DateTime>("ReservationStartDate");

                    b.Property<string>("ReservationState");

                    b.Property<double>("TotalCost");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("GuestId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsBanned");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSyncNeeded")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("LastName");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("RoleName");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAlternateKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Administrator", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Apartment", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.Guest")
                        .WithMany("RentedApartments")
                        .HasForeignKey("GuestUserId");

                    b.HasOne("ApartmentReservation.Domain.Entities.Host", "Host")
                        .WithMany("ApartmentsForRental")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("ApartmentReservation.Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.ApartmentAmenity", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.Amenity", "Amenity")
                        .WithMany("ApartmentAmenities")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApartmentReservation.Domain.Entities.Apartment", "Apartment")
                        .WithMany("ApartmentAmenities")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Comment", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.Apartment", "Apartment")
                        .WithMany("Comments")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("ApartmentReservation.Domain.Entities.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.ForRentalDate", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.Apartment", "Apartment")
                        .WithMany("ForRentalDates")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Guest", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Host", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Image", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.Apartment", "Apartment")
                        .WithMany("Images")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Location", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("ApartmentReservation.Domain.Entities.Reservation", b =>
                {
                    b.HasOne("ApartmentReservation.Domain.Entities.Apartment", "Apartment")
                        .WithMany("Reservations")
                        .HasForeignKey("ApartmentId");

                    b.HasOne("ApartmentReservation.Domain.Entities.Guest", "Guest")
                        .WithMany("Reservations")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
