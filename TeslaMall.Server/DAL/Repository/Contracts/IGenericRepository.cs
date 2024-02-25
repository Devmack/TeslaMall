namespace TeslaMall.Server.DAL.Repository.Contracts;

public interface IGenericRepository<T> where T : class
{
    public Task<bool> AddAsync(T model);
    public Task<bool> RemoveAsync(T model);
    public Task<bool> UpdateAsync(T model);
    public Task<ICollection<T>> GetAllAsync();
    public Task<T> GetSingleAsync(Guid id);
}
