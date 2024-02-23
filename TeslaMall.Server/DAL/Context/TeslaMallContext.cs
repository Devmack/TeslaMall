using Microsoft.EntityFrameworkCore;
using TeslaMall.Server.DAL.Seeder;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Context;

public class TeslaMallContext : DbContext
{
    public DbSet<TeslaCar> Cars { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<ReservationPeriod> ReservationPeriods { get; set; }
    public DbSet<Location> RentalLocations { get; set; }

    public TeslaMallContext(){}
    public TeslaMallContext(DbContextOptions<TeslaMallContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TeslaMallDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Location>()
            .HasMany(l => l.CarsAtLocation)
            .WithOne(c => c.RelatedLocation)
            .HasForeignKey(c => c.RelatedLocationId);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.RentedCar)
            .WithOne(c => c.RelatedReservation)
            .HasForeignKey<TeslaCar>(c => c.RelatedReservationId);

        modelBuilder.Entity<ReservationPeriod>()
            .HasOne(rp => rp.RelatedReservation)
            .WithOne(r => r.ReservationPeriod)
            .HasForeignKey<ReservationPeriod>(rp => rp.RelatedReservationId);

        new TeslaMallSeeder().SeedData(modelBuilder);

    }




}
