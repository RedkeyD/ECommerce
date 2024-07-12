using Application.Shop.Carts.Dtos;

namespace Application.Shop.Carts.Extensions
{
    internal static class CartDtoMappingExtensions
    {
        public static CartDto MapToDto( this CartDto cartDto )
        {
            return new CartDto( cartDto.CreatedDate, cartDto.CartItems, cartDto.User );
        }
    }
}