using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Configurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder
        .HasMany(l => l.CarsAtLocation)
        .WithOne(c => c.RelatedLocation)
        .HasForeignKey(c => c.RelatedLocationId);
    }
}
