using Domain.Entities;

namespace Application.Users
{
    public interface IUserRepository
    {
        Task<bool> IsUserExistsAsync( long userId);
        Task<User> GetByIdAsync( long userId );
    }
}