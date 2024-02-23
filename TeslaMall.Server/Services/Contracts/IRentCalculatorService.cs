using TeslaMall.Server.Models;

namespace TeslaMall.Server.Services.Contracts;

public interface IRentCalculatorService
{
    public float CalculateCostOfRent(Reservation reservation);
}
