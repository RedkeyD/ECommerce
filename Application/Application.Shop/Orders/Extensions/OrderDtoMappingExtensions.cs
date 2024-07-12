using Application.Shop.Orders.Dtos;

namespace Application.Shop.Orders.Extensions
{
    internal static class OrderDtoMappingExtensions
    {
        public static OrderDto MapToDto( this OrderDto orderDto )
        {
            return new OrderDto( orderDto.OrderDate, orderDto.Status, orderDto.User, orderDto.OrderItems );
        }
    }
}