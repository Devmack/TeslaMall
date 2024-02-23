namespace TeslaMall.Server.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; }

    public BaseModel()
    {
        
    }
    public BaseModel(Guid Id)
    {
        this.Id = Id;
    }
}
