using Application.Shop.Carts.Dtos;
using Domain.Entities;

namespace Application.Shop.Carts.Extensions
{
    internal static class CartDtoMappingExtensions
    {
        public static CartDto MapToDto( this Cart cart )
        {
            return new CartDto( cart.CreatedDate, cart.CartItems, cart.User );
        }
    }
}