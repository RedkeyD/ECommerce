using Domain.Entities;

namespace Application.Shop.Products.Dtos
{
    public sealed record ProductDto(
        string Name,
        string Description,
        decimal Price,
        string ImageUrl,
        Category Category,
        ICollection<Review> Reviews );
}