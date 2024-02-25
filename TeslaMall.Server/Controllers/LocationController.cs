using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TeslaMall.Server.DAL.Repository.Contracts;
using TeslaMall.Server.DTO.Models.Car;
using TeslaMall.Server.DTO.Models.Location;

namespace TeslaMall.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationController : ControllerBase
{
    private readonly IlocationRepository locationRepository;
    private readonly IMapper mapper;

    public LocationController(IlocationRepository locationRepository, IMapper mapper)
    {
        this.locationRepository = locationRepository;
        this.mapper = mapper;
    }

    [HttpGet]
    [Route("/Locations")]
    [ProducesResponseType(typeof(int), 200)]
    [ProducesResponseType(typeof(int), 500)]
    public async Task<ActionResult<List<LocationDTO>>> GetAllLocation()
    {
        var collectionsFound = await locationRepository.GetAllAsync();
        var collectionMapped = mapper.Map<List<LocationDTO>>(collectionsFound);
        return collectionMapped;
    }

    [HttpGet]
    [Route("/Locations/{LocationName}/Cars")]
    [ProducesResponseType(typeof(int), 200)]
    [ProducesResponseType(typeof(int), 500)]
    public async Task<ActionResult<List<CarDTO>>> GetCarAtLocation(string LocationName)
    {
        var collectionsFound = await locationRepository.GetAvailableCarsAtLocation(LocationName);
        var collectionMapped = mapper.Map<List<CarDTO>>(collectionsFound);

        return collectionMapped;
    }
}
