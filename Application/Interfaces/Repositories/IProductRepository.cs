using Domain.Entities;

namespace Application.Interfaces.Repositories;
public interface IProductRepository
{
    Task<Product> GetByIdAsync( Guid id );
}