using TeslaMall.Server.Models;
using TeslaMall.Server.Services.Contracts;

namespace TeslaMall.Server.Services.Implementations
{
    public class PaymentGateService : IPaymentGateService
    {
        public void Pay(Reservation reservation)
        {   
            //Later on replace with custom reservation logic
            reservation.IsReservationPaid = true;
        }
    }
}
