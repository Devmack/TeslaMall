
using TeslaMall.Server.Services.Contracts;

namespace TeslaMall.Server.Models;

public sealed class Reservation : BaseModel
{
    public Guid RentedCarId { get; init; }
    public TeslaCar RentedCar { get; init; }
    public ReservationPeriod ReservationPeriod { get; set; }
    public float ReservationCosts { get; set; }
    public bool IsReservationConfirmed { get; private set; }
    public bool IsReservationPaid { get; private set; }

    public Guid? UserReservationId { get; set; }
    public UserReservation? UserReservation { get; set; }


    public Reservation()
    {
        
    }
    public Reservation(Guid Id, TeslaCar rentedCar, ReservationPeriod reservationPeriod, Guid carId) : base(Id)
    {
        RentedCar = rentedCar;
        RentedCarId = carId;    
        ReservationPeriod = reservationPeriod;
    }

    public void ConfirmReservation()
    {   
        IsReservationConfirmed = true;
        IsReservationPaid = true;
        RentedCar.CurrentCarStatus = CarStatus.RENTED;
    }


    public void CalculateReservationCost(IRentCalculatorService calculationService)
    {
        ReservationCosts = calculationService.CalculateCostOfRent(this);
    }

    public void CancelReservation()
    {
        IsReservationConfirmed = false;
        RentedCar.RelatedReservationId = null;
        RentedCar.CurrentCarStatus = CarStatus.AVAILABLE;
    }
}
