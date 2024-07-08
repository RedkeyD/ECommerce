using Domain.Entities;

namespace Application.Carts.Commands.RemoveProductFromCart;

public static class RemoveProductFromCartCommandValidator
{
    public static void ValidateCartId( Guid cartId )
    {
        if ( cartId == Guid.Empty )
        {
            throw new ArgumentException( "Cart ID cannot be empty", nameof( cartId ) );
        }
    }

    public static void ValidateProductId( Guid productId )
    {
        if ( productId == Guid.Empty )
        {
            throw new ArgumentException( "Product ID cannot be empty", nameof( productId ) );
        }
    }

    public static void ValidateCart( Cart cart )
    {
        if ( cart == null )
        {
            throw new Exception( "Cart not found" );
        }
    }
}