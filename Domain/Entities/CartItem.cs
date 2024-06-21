namespace Domain.Entities;

public class CartItem
{
    public Guid CartItemId { get; private init; }
    public Guid CartId { get; private set; }
    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public ShoppingCart ShoppingCart { get; private set; }
    public Product Product { get; private set; }

    public CartItem( Guid cartId, Guid productId, int quantity )
    {
        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        CartItemId = Guid.NewGuid();
        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
    }

    private CartItem() { }

    public void SetQuantity( int quantity )
    {
        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        Quantity = quantity;
    }
}
