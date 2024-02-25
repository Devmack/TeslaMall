using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Repository.Contracts
{
    public interface IlocationRepository : IGenericRepository<Location>
    {
        public Task<ICollection<TeslaCar>> GetAvailableCarsAtLocation(string LocationName);
    }
}
