namespace Application.Carts.Commands.AddProductToCart;

public class AddProductToCartCommand
{
    public Guid CartId { get; }
    public Guid ProductId { get; }
    public int Quantity { get; }

    public AddProductToCartCommand( Guid cartId, Guid productId, int quantity )
    {
        AddProductToCartCommandValidator.ValidateCartId( cartId );
        AddProductToCartCommandValidator.ValidateProductId( productId );
        AddProductToCartCommandValidator.ValidateQuantity( quantity );

        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
    }
}
