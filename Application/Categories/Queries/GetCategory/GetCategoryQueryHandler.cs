using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Categories.Queries.GetCategory;

public class GetCategoryQueryHandler
{
    private readonly ICategoryRepository _categoryRepository;

    public GetCategoryQueryHandler( ICategoryRepository categoryRepository )
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Category> Handle( GetCategoryQuery query )
    {
        GetCategoryQueryValidator.ValidateCategoryId( query.CategoryId );

        Category category = await _categoryRepository.GetByIdAsync( query.CategoryId );

        GetCategoryQueryValidator.ValidateCategory( category );

        return category;
    }
}
