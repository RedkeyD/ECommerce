using Domain.Entities;

namespace Application.Interfaces;
public interface IProductRepository
{
    Task<Product> GetByIdAsync( Guid id );
}