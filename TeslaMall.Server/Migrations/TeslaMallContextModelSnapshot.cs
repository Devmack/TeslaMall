﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeslaMall.Server.DAL.Context;

#nullable disable

namespace TeslaMall.Server.Migrations
{
    [DbContext(typeof(TeslaMallContext))]
    partial class TeslaMallContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RentalLocations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"),
                            LocationName = "Palma Airport"
                        },
                        new
                        {
                            Id = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"),
                            LocationName = "Palma City Center"
                        },
                        new
                        {
                            Id = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"),
                            LocationName = "Alcudia"
                        },
                        new
                        {
                            Id = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"),
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
                            Id = new Guid("db8bca1a-1c7e-40da-85f7-3dacda4f436a"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c")
                        },
                        new
                        {
                            Id = new Guid("5fd75550-1f45-4bff-bc1b-b8ed801ee29f"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c")
                        },
                        new
                        {
                            Id = new Guid("bec0ee30-9633-47f1-8b4b-fb912bb7897c"),
                            CurrentCarStatus = 1,
                            ModelName = "Model X",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c")
                        },
                        new
                        {
                            Id = new Guid("100361e1-e764-471b-9d25-98d0dd8b90d4"),
                            CurrentCarStatus = 1,
                            ModelName = "Model Y",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a")
                        },
                        new
                        {
                            Id = new Guid("544bd22d-b9f4-4424-87f1-5126c672dccd"),
                            CurrentCarStatus = 1,
                            ModelName = "Model Y",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a")
                        },
                        new
                        {
                            Id = new Guid("782dd2b8-cd63-4c24-8af7-9f624dabf6d1"),
                            CurrentCarStatus = 1,
                            ModelName = "Model X",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a")
                        },
                        new
                        {
                            Id = new Guid("4b8d652f-0aed-4000-9e8f-70b7c3aa2748"),
                            CurrentCarStatus = 1,
                            ModelName = "Model Y",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b")
                        },
                        new
                        {
                            Id = new Guid("8e9dc3a8-d243-4b04-9d05-a42db56e9bbd"),
                            CurrentCarStatus = 1,
                            ModelName = "Model 3",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b")
                        },
                        new
                        {
                            Id = new Guid("30a6582e-ee83-4869-9b9a-2abbd3c20a60"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b")
                        },
                        new
                        {
                            Id = new Guid("3cc7589c-d881-4f9d-b576-e77436b557d4"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d")
                        },
                        new
                        {
                            Id = new Guid("c0f4bdab-2a2b-492c-ade4-55a3dc09fa0f"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d")
                        },
                        new
                        {
                            Id = new Guid("f3136b5e-d3b9-4e42-9da6-3fe1cefb7fc2"),
                            CurrentCarStatus = 1,
                            ModelName = "Model S",
                            RelatedLocationId = new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d")
                        });
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
