using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Configurations;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder
        .HasOne(r => r.RentedCar)
        .WithOne(c => c.RelatedReservation)
        .HasForeignKey<TeslaCar>(c => c.RelatedReservationId);
    }
}
