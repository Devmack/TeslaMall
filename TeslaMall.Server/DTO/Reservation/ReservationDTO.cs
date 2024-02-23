using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Car;
using TeslaMall.Server.DTO.ReservationPeriod;

namespace TeslaMall.Server.DTO.Reservation;

public record ReservationDTO : BaseDTO
{
    public Guid Id { get; init; }

    [Required(ErrorMessage = "Rented car is required")]
    public CarDTO RentedCar { get; init; }

    [Required(ErrorMessage = "Reservation period is required")]
    public ReservationPeriodDTO ReservationPeriod { get; init; }

    public float ReservationCosts { get; init; }

    public bool IsReservationConfirmed { get; init; }

    public bool IsReservationPaid { get; init; }

    public ReservationDTO(Guid id, CarDTO rentedCar, ReservationPeriodDTO reservationPeriod) : base(id)
    {
        RentedCar = rentedCar;
        ReservationPeriod = reservationPeriod;
    }
}
