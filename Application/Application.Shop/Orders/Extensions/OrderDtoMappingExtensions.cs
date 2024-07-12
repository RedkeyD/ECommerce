using Application.Shop.Orders.Dtos;
using Domain.Entities;

namespace Application.Shop.Orders.Extensions
{
    internal static class OrderDtoMappingExtensions
    {
        public static OrderDto MapToDto( this Order order )
        {
            return new OrderDto( order.OrderDate, order.Status, order.User, order.OrderItems );
        }
    }
}