using Application.Users;
using Domain.Entities;
using Infrastructure.Foundation.EntityFramework;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PgDbContext _context;

        public UserRepository( PgDbContext context )
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync( long id )
        {
            return await _context.Users.FindAsync( id );
        }

        public Task<bool> IsUserExistsAsync( long userId )
        {
            throw new NotImplementedException();
        }
    }
}