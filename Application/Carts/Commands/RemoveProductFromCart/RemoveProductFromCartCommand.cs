namespace Application.Carts.Commands.RemoveProductFromCart;

public class RemoveProductFromCartCommand
{
    public Guid CartId { get; }
    public Guid ProductId { get; }

    public RemoveProductFromCartCommand( Guid cartId, Guid productId )
    {
        if ( cartId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( cartId )}' cannot be null " );
        }

        if ( productId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( productId )}' cannot be null " );
        }

        CartId = cartId;
        ProductId = productId;
    }
}
