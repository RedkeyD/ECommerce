using Application.Shop.Categories.Dtos;
using Domain.Entities;

namespace Application.Shop.Categories.Extensions
{
    internal static class CategoryDtoMappingExtensions
    {
        public static CategoryDto MapToDto( this Category category )
        {
            return new CategoryDto( category.Name, category.Description, category.Products );
        }
    }
}