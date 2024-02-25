﻿using Microsoft.EntityFrameworkCore;
using TeslaMall.Server.DAL.Context;
using TeslaMall.Server.DAL.Repository.Contracts;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Repository.Implementations;

public sealed class ReservationRepository : IReservationRepository
{
    private readonly TeslaMallContext ctx;

    public ReservationRepository(TeslaMallContext ctx)
    {
        this.ctx = ctx;
    }
    public async Task<bool> AddAsync(Reservation reservation)
    {   
        await ctx.Reservations.AddAsync(reservation);
        var car = await ctx.Cars.FirstAsync(c => c.Id == reservation.RentedCarId);
        if (car != null) { car.RelatedReservationId = reservation.Id; } else
        {
            throw new Exception("There is no car with given id from reservation!");
        }
        
        return await ChangeDatabaseAsync();
    }

    public async Task<bool> CancelReservationAsync(Reservation reservation)
    {
        reservation.CancelReservation();
        return await ChangeDatabaseAsync();
    }

    public async Task<bool> ConfirmReservationAsync(Reservation reservation, UserReservation user)
    {
        reservation.ConfirmReservation();
        await ctx.UserReservations.AddAsync(user);
        return await ChangeDatabaseAsync();
    }

    public async Task<ICollection<Reservation>> GetAllAsync()
    {
        return await ctx.Reservations.ToListAsync();
    }

    public async Task<Reservation> GetSingleAsync(Guid id)
    {
        return await ctx.Reservations.Include(r => r.RentedCar).FirstAsync(e => e.Id.Equals(id));
    }

    public async Task<bool> RemoveAsync(Reservation model)
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
