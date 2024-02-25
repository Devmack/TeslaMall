using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Repository.Contracts
{
    public interface IlocationRepository : IGenericRepository<Location>
    {
        public Task<ICollection<TeslaCar>> GetAvailableCarsAtLocation(string LocationName);
        public Task<bool> UpdateCarLocation(TeslaCar car);
        public Task<TeslaCar> GetCarById(Guid carId);
    }
}
