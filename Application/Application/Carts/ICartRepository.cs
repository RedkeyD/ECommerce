using Domain.Entities;

namespace Application.Carts
{
    public interface ICartRepository
    {
        Task<bool> IsCartExistsAsync( Guid CartPublicId );
        Task<Cart> GetByIdAsync( Guid cartId );
        Task UpdateAsync( Cart cart );
    }
}