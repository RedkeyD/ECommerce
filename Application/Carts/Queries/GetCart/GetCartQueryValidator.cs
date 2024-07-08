using Domain.Entities;

namespace Application.Carts.Queries.GetCart;

public static class GetCartQueryValidator
{
    public static void ValidateCartId( Guid cartId )
    {
        if ( cartId == Guid.Empty )
        {
            throw new ArgumentException( "Cart ID cannot be empty", nameof( cartId ) );
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