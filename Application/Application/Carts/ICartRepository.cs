using Application.Abstractions.Repositories;
using Domain.Entities;

namespace Application.Carts
{
    public interface ICartRepository : IAddRepository<Cart>, IRemoveRepository<Cart>
    {
        Task<bool> IsCartExistsAsync( Guid CartPublicId );
        Task<Cart> GetByIdAsync( Guid cartId );
    }
}