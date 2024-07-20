namespace Domain.Entities
{
    public class OrderItem
    {
        public long Id { get; }
        public Guid PublicId { get; }
        public long OrderId { get; }
        public long ProductId { get; }
        public decimal Quantity { get; }
        public decimal Price { get; }
        public string Currency { get; }
        public Order Order { get; }
        public Product Product { get; }

        public OrderItem( long orderId, long productId, decimal quantity, decimal price, string currency )
        {
            if ( orderId == null )
            {
                throw new ArgumentException( $"'{nameof( orderId )}' cannot be null " );
            }

            if ( productId == null )
            {
                throw new ArgumentException( $"'{nameof( productId )}' cannot be null " );
            }

            if ( quantity <= 0 )
            {
                throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
            }

            if ( price <= 0 )
            {
                throw new ArgumentException( $"'{nameof( price )}' must be greater than zero.", nameof( price ) );
            }

            if ( string.IsNullOrWhiteSpace( currency ) )
            {
                throw new ArgumentException( $"'{nameof( currency )}' cannot be null " );
            }

            PublicId = Guid.NewGuid();
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            Currency = currency;
        }
    }
}