namespace TeslaMall.Server.DTO.Models;

public record BaseDTO
{
    public Guid id { get; set; }

    public BaseDTO(Guid id)
    {
        this.id = id;
    }

    public BaseDTO()
    {
        
    }
}
