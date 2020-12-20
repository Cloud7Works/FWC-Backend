using System.Collections.Generic;
using System.Threading.Tasks;


namespace FWC.RMS.ApplicationCore.Data
{
    public interface IAsyncRepository<T, TIdType> where T : BaseEntity<TIdType>
    {
        Task<T> GetByIdAsync(long id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}
