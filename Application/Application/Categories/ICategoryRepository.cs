using Domain.Entities;

namespace Application.Categories
{
    public interface ICategoryRepository
    {
        Task<bool> IsCategoryExistsAsync( Guid CartPublicId );
        Task<Category> GetByIdAsync( Guid categoryId );
    }
}