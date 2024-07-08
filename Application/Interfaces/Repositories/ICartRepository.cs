using Domain.Entities;

namespace Application.Interfaces.Repositories;
public interface ICartRepository
{
    Task<Cart> GetByIdAsync( Guid cartId );
    Task UpdateAsync( Cart cart );
}