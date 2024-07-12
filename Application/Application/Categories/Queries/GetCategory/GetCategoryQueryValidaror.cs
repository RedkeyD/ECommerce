using Domain.Entities;

namespace Application.Categories.Queries.GetCategory;

public static class GetCategoryQueryValidator
{
    public static void ValidateCategoryId( Guid categoryId )
    {
        if ( categoryId == Guid.Empty )
        {
            throw new ArgumentException( "category ID cannot be empty", nameof( categoryId ) );
        }
    }

    public static void ValidateCategory( Category category )
    {
        if ( category == null )
        {
            throw new Exception( "category not found" );
        }
    }
}