using Domain.Entities;

namespace Application.Users
{
    public interface IUserRepository
    {
        Task<bool> IsUserExistsAsync( Guid userId );
        Task<User> GetByIdAsync( Guid userId );
    }
}