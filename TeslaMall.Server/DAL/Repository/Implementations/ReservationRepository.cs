using TeslaMall.Server.DAL.Repository.Contracts;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Repository.Implementations;

public class ReservationRepository : IReservationRepository
{
    public Task AddAsync(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CancelReservationAsync(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ConfirmReservation(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ConfirmReservationAsync(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Reservation>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> GetSingleAsync(int id)
    {
        throw new NotImplementedException();
    }
}
