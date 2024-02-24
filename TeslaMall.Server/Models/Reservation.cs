
using TeslaMall.Server.Services.Contracts;

namespace TeslaMall.Server.Models;

public sealed class Reservation : BaseModel
{
    public Guid RentedCarId { get; init; }
    public TeslaCar RentedCar { get; init; }
    public ReservationPeriod ReservationPeriod { get; set; }
    public float ReservationCosts { get => _reservationCosts; private set { _ = value >= 0 ? value : throw new Exception("Reservation costs cannot be below zero");} }
    public bool IsReservationConfirmed { get; private set; }
    public bool IsReservationPaid { get; private set; }

    private float _reservationCosts;

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
        if (RentedCar.CurrentCarStatus == CarStatus.RENTED) { throw new Exception("Car is already rented"); }
        if (!IsReservationPaid) { throw new Exception("You must pay before you can confirm reservation"); } 
        IsReservationConfirmed = true;
        RentedCar.CurrentCarStatus = CarStatus.RENTED;
    }


    public void CalculateReservationCost(IRentCalculatorService calculationService)
    {
        ReservationCosts = calculationService.CalculateCostOfRent(this);
    }

    public void CancelReservation()
    {
        IsReservationConfirmed = false;
        RentedCar.CurrentCarStatus = CarStatus.AVAILABLE;
    }
}
