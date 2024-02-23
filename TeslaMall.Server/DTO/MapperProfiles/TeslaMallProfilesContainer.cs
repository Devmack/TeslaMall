using AutoMapper;
using TeslaMall.Server.DTO.Models.Car;
using TeslaMall.Server.DTO.Models.Location;
using TeslaMall.Server.DTO.Models.Reservation;
using TeslaMall.Server.DTO.Models.ReservationPeriod;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DTO.MapperProfiles;

public class TeslaMallProfilesContainer : Profile
{
    public TeslaMallProfilesContainer()
    {
        CreateMap<TeslaCar, CarDTO>().ReverseMap();
        CreateMap<Location, LocationDTO>().ReverseMap();
        CreateMap<Reservation, ReservationDTO>().ReverseMap();
        CreateMap<ReservationPeriod, ReservationPeriodDTO>().ReverseMap();

    }
}
