using TeslaMall.Server.Models;

namespace TeslaMall.Server.Services.Contracts;

public interface IRentCalculatorService
{
    public decimal CalculateCostOfRent(Reservation reservation);
}
