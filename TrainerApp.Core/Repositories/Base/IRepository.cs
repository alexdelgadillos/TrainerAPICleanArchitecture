using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrainerApp.Core.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T t);
        Task<T> UpdateAsync(T t);
        Task<T> DeleteAsync(T t);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

    }
}