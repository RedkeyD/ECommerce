namespace Application.Carts.Commands.UpdateProductQuantityInCart;

public class UpdateProductQuantityInCartCommand
{
    public Guid CartId { get; }
    public Guid ProductId { get; }
    public int Quantity { get; }

    public UpdateProductQuantityInCartCommand( Guid cartId, Guid productId, int quantity )
    {
        UpdateProductQuantityInCartCommandValidator.ValidateCartId( cartId );
        UpdateProductQuantityInCartCommandValidator.ValidateProductId( productId );
        UpdateProductQuantityInCartCommandValidator.ValidateQuantity( quantity );

        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
    }
}
