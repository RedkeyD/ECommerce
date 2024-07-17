using Application.Abstractions.Repositories;
using Domain.Entities;

namespace Application.Carts
{
    public interface ICartRepository : IAddRepository<Product>, IRemoveRepository<Product>
    {
        Task<bool> IsCartExistsAsync( Guid CartPublicId );
        Task<Cart> GetByIdAsync( Guid cartId );
    }
}