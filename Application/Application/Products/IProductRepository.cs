using Domain.Entities;

namespace Application.Products
{
    public interface IProductRepository
    {
        Task<bool> IsProductExistsAsync( Guid CartPublicId );
        Task<Product> GetByIdAsync( Guid id );
    }
}