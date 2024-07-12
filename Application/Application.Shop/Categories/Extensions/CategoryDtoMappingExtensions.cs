using Application.Shop.Categories.Dtos;

namespace Application.Shop.Categories.Extensions
{
    internal static class CategoryDtoMappingExtensions
    {
        public static CategoryDto MapToDto( this CategoryDto categoryDto )
        {
            return new CategoryDto( categoryDto.Name, categoryDto.Description, categoryDto.Products );
        }
    }
}
