namespace Domain.Entities
{
    public class CartItem
    {
        public long Id { get; private set; }
        public Guid PublicId { get; }
        public long CartId { get; }
        public long ProductId { get; }
        public int Quantity { get; private set; }
        public Cart Cart { get; }
        public Product Product { get; }

        private int _initialQuantity = 1;

        public CartItem( long cartId, long productId )
        {
            if ( cartId == null )
            {
                throw new ArgumentException( $"'{nameof( cartId )}' cannot be null " );
            }

            if ( productId == null )
            {
                throw new ArgumentException( $"'{nameof( productId )}' cannot be null " );
            }

            PublicId = Guid.NewGuid();
            CartId = cartId;
            ProductId = productId;
            Quantity = _initialQuantity;
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