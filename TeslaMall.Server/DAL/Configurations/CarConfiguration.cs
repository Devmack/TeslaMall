using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Configurations;

public class CarConfiguraion : IEntityTypeConfiguration<TeslaCar>
{
    public void Configure(EntityTypeBuilder<TeslaCar> builder)
    {
        builder
        .HasOne(el => el.RelatedReservation)
        .WithOne(el => el.RentedCar)
        .HasForeignKey<Reservation>(el => el.RentedCarId);
    }
}
