namespace Application.Carts.Commands.RemoveProductFromCart;

public class RemoveProductFromCartCommand
{
    public Guid CartId { get; }
    public Guid ProductId { get; }

    public RemoveProductFromCartCommand( Guid cartId, Guid productId )
    {
        RemoveProductFromCartCommandValidator.ValidateCartId( cartId );
        RemoveProductFromCartCommandValidator.ValidateProductId( productId );

        CartId = cartId;
        ProductId = productId;
    }
}