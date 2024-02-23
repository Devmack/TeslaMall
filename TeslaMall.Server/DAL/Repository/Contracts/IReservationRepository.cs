using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Repository.Contracts;

public interface IReservationRepository
{
    public Task AddAsync(Reservation reservation);
    public Task<bool> ConfirmReservationAsync(Reservation reservation);
    public Task<bool> ConfirmReservation(Reservation reservation);
    public Task<bool> CancelReservationAsync(Reservation reservation);
    public Task<ICollection<Reservation>> GetAllAsync();
    public Task<Reservation> GetSingleAsync(int id);
}
