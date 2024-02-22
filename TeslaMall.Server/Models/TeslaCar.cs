
namespace TeslaMall.Server.Models;

public sealed class TeslaCar : BaseModel
{
    public string ModelName { get; set; }
    public CarStatus CurrentCarStatus { get; set; } = CarStatus.AVAILABLE;

    public TeslaCar(Guid Id, string modelName) : base(Id)
    {
        ModelName = modelName;
    }

    public override bool Equals(object? obj)
    {
        return obj is TeslaCar car &&
               id.Equals(car.id) &&
               ModelName == car.ModelName;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(id, ModelName);
    }
}
