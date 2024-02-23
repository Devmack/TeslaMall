using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Models.Car;

namespace TeslaMall.Server.DTO.Models.Location;

public record LocationDTO : BaseDTO
{
    [Required(ErrorMessage = "Location name is required")]
    [MaxLength(30, ErrorMessage = "Model name cannot be longer than 30 characters")]
    public string LocationName { get; init; }
    public ICollection<CarDTO> CarsAtLocation { get; init; }

    public LocationDTO(Guid id, string locationName, ICollection<CarDTO> carsAtLocation) : base(id)
    {
        LocationName = locationName;
        CarsAtLocation = carsAtLocation;
    }
}
