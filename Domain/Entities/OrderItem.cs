namespace Domain.Entities;
public class OrderItem
{
    public Guid OrderItemId { get; private init; }
    public Guid OrderId { get; private set; }
    public Guid ProductId { get; private set; }
    public decimal Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }
    public Order Order { get; private set; }
    public Product Product { get; private set; }

    public OrderItem( Guid orderId, Guid productId, int quantity, decimal unitPrice )
    {
        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        if ( unitPrice <= 0 )
        {
            throw new ArgumentException( $"'{nameof( unitPrice )}' must be greater than zero.", nameof( unitPrice ) );
        }

        OrderItemId = Guid.NewGuid();
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public void SetQuantity( int quantity )
    {
        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        Quantity = quantity;
    }

    public void SetUnitPrice( decimal unitPrice )
    {
        if ( unitPrice <= 0 )
        {
            throw new ArgumentException( $"'{nameof( unitPrice )}' must be greater than zero.", nameof( unitPrice ) );
        }

        UnitPrice = unitPrice;
    }
}
