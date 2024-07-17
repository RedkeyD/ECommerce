using Application.Shop.Products.Dtos;
using Domain.Entities;

namespace Application.Shop.Products.Extensions
{
    internal static class ProductDtoMappingExtensions
    {
        public static ProductDto MapToDto( this Product product )
        {
            return new ProductDto( product.Name, product.Description, product.Price, product.ImageUrl, product.Category, product.Reviews );
        }
    }
}