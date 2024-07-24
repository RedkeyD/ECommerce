using Application.Users;
using Domain.Entities;
using Infrastructure.Foundation.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PgDbContext _context;

        public UserRepository( PgDbContext context )
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync( Guid userId )
        {
            return await _context.Users.FirstOrDefaultAsync( u => u.PublicId == userId );
        }

        public async Task<bool> IsUserExistsAsync( Guid userId )
        {
            var user = await _context.Users.FirstOrDefaultAsync( u => u.PublicId == userId );

            return user != null;
        }
    }
}