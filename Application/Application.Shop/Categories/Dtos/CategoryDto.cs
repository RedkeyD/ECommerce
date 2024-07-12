using Domain.Entities;

namespace Application.Shop.Categories.Dtos
{
    public record CategoryDto(
        string Name,
        string Description,
        ICollection<Product> Products
        );
}