using Microsoft.EntityFrameworkCore;
using TeslaMall.Server.DAL.Context;
using TeslaMall.Server.DAL.Repository.Contracts;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Repository.Implementations;

public sealed class LocationRepository : IlocationRepository
{
    private readonly TeslaMallContext ctx;

    public LocationRepository(TeslaMallContext ctx)
    {
        this.ctx = ctx;
    }
    public async Task<bool> AddAsync(Location model)
    {
        await ctx.RentalLocations.AddAsync(model);
        return await ChangeDatabaseAsync();
    }

    public async Task<ICollection<Location>> GetAllAsync()
    {
        return await ctx.RentalLocations.Include(l => l.CarsAtLocation).ToListAsync();
    }

    public async Task<Location> GetSingleAsync(Guid id)
    {
        return await ctx.RentalLocations.FirstAsync(e => e.Id.Equals(id));

    }

    public async Task<bool> RemoveAsync(Location model)
    {
        var targetFound = await GetSingleAsync(model.Id);
        if (targetFound != null)
        {
            await ChangeDatabaseAsync();
        }
        throw new Exception("Model with given id does not exists");
    }

    private async Task<bool> ChangeDatabaseAsync()
    {
        var opResult = await ctx.SaveChangesAsync();
        return opResult != 0 ? true : false;
    }
}
