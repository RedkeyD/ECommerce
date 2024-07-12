using Application.Shop.Products.Dtos;

namespace Application.Shop.Products.Extensions
{
    internal static class ProductDtoMappingExtensions
    {
        public static ProductDto MapToDto( this ProductDto productDto )
        {
            return new ProductDto( productDto.Name, productDto.Description, productDto.Price, productDto.imageUrl, productDto.Category, productDto.Reviews );
        }
    }
}
