using Domain.Entities;
using Domain.Enums;

namespace Application.Shop.Orders.Dtos
{
    public record OrderDto(
        DateTime OrderDate,
        OrderStatus Status,
        User User,
        ICollection<OrderItem> OrderItems );
}