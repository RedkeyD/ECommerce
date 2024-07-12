using Domain.Entities;

namespace Application.Shop.Carts.Dtos
{
    public record CartDto(
        DateTime CreatedDate,
        ICollection<CartItem> CartItems,
        User User );
}