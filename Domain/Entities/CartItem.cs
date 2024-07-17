namespace Domain.Entities
{
    public class CartItem
    {
        public long Id { get; }
        public Guid PublicId { get; }
        public Guid CartId { get; }
        public Guid ProductId { get; }
        public int Quantity { get; private set; }
        public Cart Cart { get; }
        public Product Product { get; }

        public CartItem( Guid cartId, Guid productId )
        {
            if ( cartId == Guid.Empty )
            {
                throw new ArgumentException( $"'{nameof( cartId )}' cannot be null " );
            }

            if ( productId == Guid.Empty )
            {
                throw new ArgumentException( $"'{nameof( productId )}' cannot be null " );
            }

            PublicId = Guid.NewGuid();
            CartId = cartId;
            ProductId = productId;
            Quantity = 1;
        }

        public void SetQuantity( int quantity )
        {
            if ( quantity <= 0 )
            {
                throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
            }

            Quantity = quantity;
        }
    }
}