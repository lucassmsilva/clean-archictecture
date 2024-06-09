using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
        void Create (T entity);
        void Update (T entity); 
        void Delete (T entity); 
        Task<T> Get(int id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(int id, CancellationToken cancellationToken);
    }
}
