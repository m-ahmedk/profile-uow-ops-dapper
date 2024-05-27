namespace CleanArch.Core;

public interface IGenericRepository<T>
{
    Task<T> GetAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<bool> AddAsync(T model);
    Task<bool> UpdateAsync(T model);
    Task<bool> DeleteAsync(int id);
}
