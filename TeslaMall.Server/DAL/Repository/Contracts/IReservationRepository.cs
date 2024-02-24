using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Repository.Contracts;

public interface IReservationRepository : IGenericRepository<Reservation>
{
    public Task<bool> ConfirmReservationAsync(Reservation reservation, UserReservation user);
    public Task<bool> CancelReservationAsync(Reservation reservation);

}
