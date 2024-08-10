using adessoTaskApi.Models.EntityModels;
using System.Runtime.InteropServices;

namespace adessoTaskApi.Data
{
    public interface IDAO<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<List<T>> CreateAsync(List<T> entities);
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int id);
        Task<bool> DeleteAllAsync();
    }
}
