using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Configurations;

public class UserReservationConfiguration : IEntityTypeConfiguration<UserReservation>
{
    public void Configure(EntityTypeBuilder<UserReservation> builder)
    {
        builder
        .HasOne(el => el.RelatedReservation);
    }
}
