using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Models.Car;

namespace TeslaMall.Server.DTO.Models.Location;

public record LocationDTO : BaseDTO
{
    [Required(ErrorMessage = "Location name is required")]
    [MaxLength(30, ErrorMessage = "Model name cannot be longer than 30 characters")]
    public string LocationName { get; init; }

    [Required(ErrorMessage = "Location description is required")]
    [MaxLength(500, ErrorMessage = "Model description cannot be longer than 500 characters")]
    public string LocationDescription { get; init; }
    public ICollection<CarDTO> CarsAtLocation { get; init; }

    public LocationDTO(Guid id, string locationName, ICollection<CarDTO> carsAtLocation, string locationDescription) : base(id)
    {
        LocationName = locationName;
        CarsAtLocation = carsAtLocation;
        LocationDescription = locationDescription;
    }
}
