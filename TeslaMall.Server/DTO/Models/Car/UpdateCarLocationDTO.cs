namespace TeslaMall.Server.DTO.Models.Car;

public record UpdateCarLocationDTO
{
    public Guid CarId { get; set; }
    public Guid LocationId { get; set; }
}
