using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TeslaMall.Server.DAL.Seeder;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Context;

public class TeslaMallContext : DbContext
{
    public DbSet<TeslaCar> Cars { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<ReservationPeriod> ReservationPeriods { get; set; }
    public DbSet<Location> RentalLocations { get; set; }

    public TeslaMallContext(){
        Database.EnsureCreated();
    }
    public TeslaMallContext(DbContextOptions<TeslaMallContext> options) : base(options) {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TeslaMallDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
        new TeslaMallSeeder().SeedData(modelBuilder);
    }

}
