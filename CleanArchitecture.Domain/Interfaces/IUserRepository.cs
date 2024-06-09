using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
