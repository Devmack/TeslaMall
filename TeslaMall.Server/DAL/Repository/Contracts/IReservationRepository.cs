using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Repository.Contracts;

public interface IReservationRepository : IGenericRepository<Reservation>
{
    public Task<bool> ConfirmReservationAsync(Reservation reservation, UserReservation user);
    public Task<bool> CancelReservationAsync(Reservation reservation);
    public Task<UserReservation> GetReservationOfByUserAssignedAsync(string email);
    public Task<bool> RemoveUserReservation(UserReservation userReservation);

}
