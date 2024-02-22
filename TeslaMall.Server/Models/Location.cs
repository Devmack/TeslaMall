

namespace TeslaMall.Server.Models;

public sealed class Location : BaseModel
{
    public string LocationName { get; set; }
    public ICollection<TeslaCar> CarsAtLocation { get; set; }
    public Location(Guid Id, string locationName, ICollection<TeslaCar> carsAtLocation) : base(Id)
    {
        LocationName = locationName;
        CarsAtLocation = carsAtLocation;
    }

    public override bool Equals(object? obj)
    {
        return obj is Location location &&
               id.Equals(location.id) &&
               LocationName == location.LocationName &&
               EqualityComparer<ICollection<TeslaCar>>.Default.Equals(CarsAtLocation, location.CarsAtLocation);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(id, LocationName, CarsAtLocation);
    }
}
