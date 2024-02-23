using TeslaMall.Server.Models;
using TeslaMall.Server.Services.Contracts;

namespace TeslaMall.Server.Services.Implementations;

public class RentCalculatorServices : IRentCalculatorService
{
    private readonly float baseFuelPerDayFactor;
    public RentCalculatorServices(float baseFuelPerDayFactor)
    {
        this.baseFuelPerDayFactor = baseFuelPerDayFactor;
    }
    public float CalculateCostOfRent(Reservation reservation)
    {
        return reservation.ReservationPeriod.ReservationLength * baseFuelPerDayFactor; 
    }
}
