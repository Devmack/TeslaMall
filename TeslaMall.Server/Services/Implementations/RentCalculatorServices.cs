using TeslaMall.Server.Models;
using TeslaMall.Server.Services.Contracts;

namespace TeslaMall.Server.Services.Implementations;

public class RentCalculatorServices : IRentCalculatorService
{
    private float baseFuelPerDayFactor;
    public RentCalculatorServices(float baseFuelPerDayFactor)
    {
        this.baseFuelPerDayFactor = baseFuelPerDayFactor;
    }
    public RentCalculatorServices()
    {
        
    }
    public float CalculateCostOfRent(Reservation reservation)
    {
        return reservation.ReservationPeriod.ReservationLength * baseFuelPerDayFactor; 
    }
}
