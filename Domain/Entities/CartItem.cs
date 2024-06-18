namespace Domain.Entities;

public class CartItem
{
    public Guid Id { get; }
    public Guid CartId { get; }
    public Guid ProductId { get; }
    public int Quantity { get; }
    public Cart ShoppingCart { get; }
    public Product Product { get; }

    public CartItem( Guid cartId, Guid productId, int quantity )
    {
        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        if ( cartId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( cartId )}' cannot be null " );
        }

        if ( productId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( productId )}' cannot be null " );
        }

        Id = Guid.NewGuid();
        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
    }
}