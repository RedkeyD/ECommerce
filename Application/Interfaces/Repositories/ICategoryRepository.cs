using Domain.Entities;

namespace Application.Interfaces.Repositories;
public interface ICategoryRepository
{
    Task<Category> GetByIdAsync( Guid categoryId );
}