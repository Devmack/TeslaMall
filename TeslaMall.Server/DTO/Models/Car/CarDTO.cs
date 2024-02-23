using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Models;
using TeslaMall.Server.DTO.Models.Location;
using TeslaMall.Server.DTO.Models.Reservation;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DTO.Models.Car;

public record CarDTO : BaseDTO
{

    [Required(ErrorMessage = "Model name is required")]
    [MaxLength(30, ErrorMessage = "Model name cannot be longer than 30 characters")]
    public string ModelName { get; init; }

    public CarStatus CurrentCarStatus { get; init; } = CarStatus.AVAILABLE;

    public Guid? RelatedLocationId { get; init; }

    public Guid? RelatedReservationId { get; init; }


    public CarDTO(Guid id, string modelName) : base(id)
    {
        ModelName = modelName;
    }
}
