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

    public async Task<ICollection<TeslaCar>> GetAvailableCarsAtLocation(string LocationName)
    {
        return await ctx.Cars
            .Include(c => c.RelatedLocation)
            .Where(c => c.RelatedLocation.LocationName == LocationName)
            .Where(c => c.RelatedReservationId == null).ToListAsync();  
    }

    public async Task<TeslaCar> GetCarById(Guid carId)
    {
        return await ctx.Cars.FirstAsync(c => c.Id == carId);
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

    public async Task<bool> UpdateAsync(Location model)
    {
        var opResult = await ctx.RentalLocations.ExecuteUpdateAsync(setters => setters
        .SetProperty(b => b.LocationName, model.LocationName)
        .SetProperty(b => b.LocationDescription, model.LocationDescription)
        .SetProperty(b => b.CarsAtLocation, model.CarsAtLocation));

        return await ChangeDatabaseAsync();
    }

    public async Task<bool> UpdateCarLocation(TeslaCar car)
    {
        var opResult = await ctx.Cars.FirstAsync(c => c.Id == car.Id);
        if (opResult != null)
        {
            opResult.RelatedLocationId = car.RelatedLocationId;
        }

        return await ChangeDatabaseAsync();
    }

    private async Task<bool> ChangeDatabaseAsync()
    {
        var opResult = await ctx.SaveChangesAsync();
        return opResult != 0 ? true : false;
    }
}
