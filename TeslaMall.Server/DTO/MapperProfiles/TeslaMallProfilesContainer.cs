﻿using AutoMapper;
using TeslaMall.Server.DTO.Models;
using TeslaMall.Server.DTO.Models.Car;
using TeslaMall.Server.DTO.Models.Location;
using TeslaMall.Server.DTO.Models.Reservation;
using TeslaMall.Server.DTO.Models.ReservationPeriod;
using TeslaMall.Server.DTO.Models.UserReservation;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DTO.MapperProfiles;

public class TeslaMallProfilesContainer : Profile
{
    public TeslaMallProfilesContainer()
    {
        CreateMap<BaseModel, BaseDTO>().ReverseMap();
        CreateMap<TeslaCar, CarDTO>().ReverseMap();
        CreateMap<Location, LocationDTO>().ReverseMap();
        CreateMap<Reservation, ReservationDTO>()
            .ForMember(dest => dest.ReservationPeriod, opt => opt.MapFrom(src => src.ReservationPeriod))
            .ReverseMap();
        CreateMap<ReservationPeriod, ReservationPeriodDTO>().ReverseMap();
        CreateMap<UserReservation, UserReservationDTO>().ReverseMap();
    }
}
