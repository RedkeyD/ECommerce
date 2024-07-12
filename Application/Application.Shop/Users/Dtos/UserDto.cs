using Domain.Entities;

namespace Application.Shop.Users.Dtos
{
    public sealed record UserDto(
        ICollection<Order> Orders,
        Cart Cart,
        string Username,
        string Email );
}