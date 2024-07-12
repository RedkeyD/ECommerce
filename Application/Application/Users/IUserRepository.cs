using Domain.Entities;

namespace Application.Users
{
    public interface IUserRepository
    {
        Task<bool> IsUserExistsAsync( Guid CartPublicId );
        Task<User> GetByIdAsync( Guid userId );
    }
}