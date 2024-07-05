namespace Application.Carts.Commands.UpdateCartItemQuantity;

public class UpdateCartItemQuantityCommand
{
    public Guid CartId { get; }
    public Guid ProductId { get; }
    public int Quantity { get; }

    public UpdateCartItemQuantityCommand( Guid cartId, Guid productId, int quantity )
    {
        if ( cartId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( cartId )}' cannot be null " );
        }

        if ( productId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( productId )}' cannot be null " );
        }

        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
    }
}
