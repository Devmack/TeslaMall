using TeslaMall.Server.Models;

namespace TeslaMall.Server.Services.Contracts;

public interface IPaymentGateService
{
    void Pay(Reservation reservation);
}
