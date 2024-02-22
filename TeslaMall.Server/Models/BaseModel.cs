namespace TeslaMall.Server.Models;

public abstract class BaseModel
{
    public readonly Guid id;

    public BaseModel(Guid Id)
    {
        id = Id;
    }
}
