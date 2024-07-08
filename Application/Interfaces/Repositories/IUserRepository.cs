using Domain.Entities;

namespace Application.Interfaces.Repositories;
public interface IUserRepository
{
    Task<User> GetByIdAsync( Guid userId );
}