using TeslaMall.Server.Models;
using TeslaMall.Server.Services.Contracts;

namespace TeslaMall.Server.Services.Implementations;

public class RentCalculatorServices : IRentCalculatorService
{
    private readonly decimal baseFuelPerDayFactor;
    public RentCalculatorServices(decimal baseFuelPerDayFactor)
    {
        this.baseFuelPerDayFactor = baseFuelPerDayFactor;
    }
    public decimal CalculateCostOfRent(Reservation reservation)
    {
        return reservation.ReservationPeriod.ReservationLength * baseFuelPerDayFactor; 
    }
}
