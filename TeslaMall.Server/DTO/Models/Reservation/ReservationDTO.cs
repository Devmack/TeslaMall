using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Models.Car;
using TeslaMall.Server.DTO.Models.ReservationPeriod;

namespace TeslaMall.Server.DTO.Models.Reservation;

public record ReservationDTO : BaseDTO
{

    [Required(ErrorMessage = "Rented car Id is required")]
    public Guid RentedCarId { get; init; }

    public CarDTO? RentedCar { get; init; }

    [Required(ErrorMessage = "Reservation period is required")]
    public ReservationPeriodDTO ReservationPeriod { get; set; }

    public float ReservationCosts { get; init; }

    public bool IsReservationConfirmed { get; init; }

    public bool IsReservationPaid { get; init; }

    public ReservationDTO() 
    {
        
    }

    public ReservationDTO(Guid id, CarDTO rentedCar, ReservationPeriodDTO reservationPeriod, Guid carId) : base(id)
    {
        RentedCar = rentedCar;
        RentedCarId = carId;
        ReservationPeriod = reservationPeriod;
    }
}
