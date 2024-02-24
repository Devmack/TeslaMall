﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeslaMall.Server.DAL.Context;

#nullable disable

namespace TeslaMall.Server.Migrations
{
    [DbContext(typeof(TeslaMallContext))]
    [Migration("20240224191337_CarIdNavigationInReservation")]
    partial class CarIdNavigationInReservation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeslaMall.Server.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LocationDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RentalLocations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"),
                            LocationDescription = "Sunny airport welcoming any visitors to join great vacation!",
                            LocationName = "Palma Airport"
                        },
                        new
                        {
                            Id = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"),
                            LocationDescription = "City center buzzing with life and music. Worth checking out!",
                            LocationName = "Palma City Center"
                        },
                        new
                        {
                            Id = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"),
                            LocationDescription = "Best coctails, parties and company. Don't wait and go!",
                            LocationName = "Alcudia"
                        },
                        new
                        {
                            Id = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"),
                            LocationDescription = "Sandy beach, full sun and relax. Rent a car and go!",
                            LocationName = "Manacor"
                        });
                });

            modelBuilder.Entity("TeslaMall.Server.Models.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsReservationConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReservationPaid")
                        .HasColumnType("bit");

                    b.Property<Guid>("RentedCarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("ReservationCosts")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("TeslaMall.Server.Models.ReservationPeriod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RelatedReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReservationEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RelatedReservationId")
                        .IsUnique();

                    b.ToTable("ReservationPeriods");
                });

            modelBuilder.Entity("TeslaMall.Server.Models.TeslaCar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrentCarStatus")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RelatedLocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RelatedReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RelatedLocationId");

                    b.HasIndex("RelatedReservationId")
                        .IsUnique()
                        .HasFilter("[RelatedReservationId] IS NOT NULL");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92607192-cd3b-4ea8-b059-156e533a8d29"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c")
                        },
                        new
                        {
                            Id = new Guid("fc5fe612-127b-482d-9942-a925eb41392a"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c")
                        },
                        new
                        {
                            Id = new Guid("d6a93350-022b-47ca-9390-548e83c607f8"),
                            CurrentCarStatus = 1,
                            ModelName = "Model X",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c")
                        },
                        new
                        {
                            Id = new Guid("77ff4072-e0e0-4160-9306-31b00740875f"),
                            CurrentCarStatus = 1,
                            ModelName = "Model Y",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a")
                        },
                        new
                        {
                            Id = new Guid("b62a6764-4ea0-4c1d-9d13-0b7a63517bde"),
                            CurrentCarStatus = 1,
                            ModelName = "Model Y",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a")
                        },
                        new
                        {
                            Id = new Guid("853d74a0-b363-46b1-a680-f98104a18615"),
                            CurrentCarStatus = 1,
                            ModelName = "Model X",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a")
                        },
                        new
                        {
                            Id = new Guid("2f5c7e0b-001f-42d7-8cf4-f08fa6869965"),
                            CurrentCarStatus = 1,
                            ModelName = "Model Y",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b")
                        },
                        new
                        {
                            Id = new Guid("8ef68d73-c424-4179-b5ff-5d17a1788cf8"),
                            CurrentCarStatus = 1,
                            ModelName = "Model 3",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b")
                        },
                        new
                        {
                            Id = new Guid("7f7045b8-4e26-45b5-b8eb-9f9fe8c8745b"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b")
                        },
                        new
                        {
                            Id = new Guid("3fb0c06e-8fd1-434b-af17-6a957d6f2503"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d")
                        },
                        new
                        {
                            Id = new Guid("834b1b1b-a658-49e2-a0b1-2b7e379c13eb"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d")
                        },
                        new
                        {
                            Id = new Guid("362a1ab0-7ead-4d2d-95ba-60997aea2802"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d")
                        });
                });

            modelBuilder.Entity("TeslaMall.Server.Models.UserReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RelatedReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ReservationCode")
                        .HasColumnType("int");

                    b.Property<string>("ReservationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RelatedReservationId");

                    b.ToTable("UserReservations");
                });

            modelBuilder.Entity("TeslaMall.Server.Models.ReservationPeriod", b =>
                {
                    b.HasOne("TeslaMall.Server.Models.Reservation", "RelatedReservation")
                        .WithOne("ReservationPeriod")
                        .HasForeignKey("TeslaMall.Server.Models.ReservationPeriod", "RelatedReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelatedReservation");
                });

            modelBuilder.Entity("TeslaMall.Server.Models.TeslaCar", b =>
                {
                    b.HasOne("TeslaMall.Server.Models.Location", "RelatedLocation")
                        .WithMany("CarsAtLocation")
                        .HasForeignKey("RelatedLocationId");

                    b.HasOne("TeslaMall.Server.Models.Reservation", "RelatedReservation")
                        .WithOne("RentedCar")
                        .HasForeignKey("TeslaMall.Server.Models.TeslaCar", "RelatedReservationId");

                    b.Navigation("RelatedLocation");

                    b.Navigation("RelatedReservation");
                });

            modelBuilder.Entity("TeslaMall.Server.Models.UserReservation", b =>
                {
                    b.HasOne("TeslaMall.Server.Models.Reservation", "RelatedReservation")
                        .WithMany()
                        .HasForeignKey("RelatedReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelatedReservation");
                });

            modelBuilder.Entity("TeslaMall.Server.Models.Location", b =>
                {
                    b.Navigation("CarsAtLocation");
                });

            modelBuilder.Entity("TeslaMall.Server.Models.Reservation", b =>
                {
                    b.Navigation("RentedCar")
                        .IsRequired();

                    b.Navigation("ReservationPeriod")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}