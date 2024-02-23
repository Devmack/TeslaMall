using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Configurations;

public class ReservationPeriodConfiguration : IEntityTypeConfiguration<ReservationPeriod>
{
    public void Configure(EntityTypeBuilder<ReservationPeriod> builder)
    {
        builder
        .HasOne(rp => rp.RelatedReservation)
        .WithOne(r => r.ReservationPeriod)
        .HasForeignKey<ReservationPeriod>(rp => rp.RelatedReservationId);
    }
}
