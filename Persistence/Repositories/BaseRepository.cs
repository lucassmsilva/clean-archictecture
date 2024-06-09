using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }
        public void Create(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            Context.Add(entity);

        }
        public void Update(T entity)
        {
            entity.DateUpdated = DateTimeOffset.UtcNow;
            Context.Update(entity);
        }


        public void Delete(T entity)
        {
            entity.DateDeleted = DateTimeOffset.UtcNow;
            Context.Remove(entity);
        }

        public async Task<T> Get(int id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<List<T>> GetAll(int id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().ToListAsync(cancellationToken);
        }
    }

}
