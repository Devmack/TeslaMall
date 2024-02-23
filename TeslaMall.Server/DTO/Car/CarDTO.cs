using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Location;
using TeslaMall.Server.DTO.Reservation;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DTO.Car;

public record CarDTO : BaseDTO
{

    [Required(ErrorMessage = "Model name is required")]
    [MaxLength(30, ErrorMessage = "Model name cannot be longer than 30 characters")]
    public string ModelName { get; init; }

    public CarStatus CurrentCarStatus { get; init; } = CarStatus.AVAILABLE;

    public Guid? RelatedLocationId { get; init; }

    public LocationDTO? RelatedLocation { get; init; }

    public Guid? RelatedReservationId { get; init; }

    public ReservationDTO? RelatedReservation { get; init; }

    public CarDTO(Guid id, string modelName, LocationDTO? relatedLocation, ReservationDTO? relatedReservation) : base(id)   
    {
        ModelName = modelName;
        RelatedLocation = relatedLocation;
        RelatedReservation = relatedReservation;
    }
}
