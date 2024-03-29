﻿using TeslaMall.Server.DAL.Context;
using TeslaMall.Server.DAL.Repository.Contracts;
using TeslaMall.Server.DAL.Repository.Implementations;
using TeslaMall.Server.Services.Contracts;
using TeslaMall.Server.Services.Implementations;

namespace TeslaMall.Server.Extensions;

public static class DalExtensionsContainer
{
    public static void InjectDAL(this IServiceCollection services)
    {
        services.AddDbContext<TeslaMallContext>();
        services.AddTransient<IReservationRepository, ReservationRepository>();
        services.AddScoped<IRentCalculatorService, RentCalculatorServices>();
        services.AddScoped<IPaymentGateService, PaymentGateService>();  
        services.AddScoped<IlocationRepository, LocationRepository>();
    }
}
