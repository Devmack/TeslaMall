
namespace TeslaMall.Server.Models;

public sealed class TeslaCar : BaseModel
{
    public string ModelName { get; set; }
    public CarStatus CurrentCarStatus { get; set; } = CarStatus.AVAILABLE;
    public Guid? RelatedLocationId { get; set; } 
    public Location? RelatedLocation { get; set; }
    public Guid? RelatedReservationId { get; set; }
    public Reservation? RelatedReservation { get; set; }

    public TeslaCar()
    {
        
    }

    public TeslaCar(Guid Id, string modelName, Location? relatedLocation, Reservation relatedReservation) : base(Id)
    {
        ModelName = modelName;
        RelatedLocation = relatedLocation;
        RelatedReservation = relatedReservation;
    }

    public override bool Equals(object? obj)
    {
        return obj is TeslaCar car &&
               Id.Equals(car.Id) &&
               ModelName == car.ModelName;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, ModelName);
    }
}
