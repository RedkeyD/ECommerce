namespace Domain.Entities;
public class OrderItem
{
    public Guid Id { get; }
    public Guid OrderId { get; }
    public Guid ProductId { get; }
    public decimal Quantity { get; private set; }
    public decimal Price { get; private set; }
    public string Currency { get; private set; }
    public Order Order { get; }
    public Product Product { get; }

    public OrderItem( Guid orderId, Guid productId, int quantity, decimal price )
    {
        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        if ( price <= 0 )
        {
            throw new ArgumentException( $"'{nameof( price )}' must be greater than zero.", nameof( price ) );
        }

        Id = Guid.NewGuid();
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        Price = price;
    }
}
