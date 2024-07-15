namespace Domain.Entities
{
    public class Cart
    {
        public long Id { get; }
        public Guid PublicId { get; }
        public Guid UserId { get; }
        public DateTime CreatedDate { get; }
        public ICollection<CartItem> CartItems { get; private set; }
        public User User { get; }

        public Cart( Guid userId )
        {
            if ( userId == Guid.Empty )
            {
                throw new ArgumentException( $"{nameof( userId )} can not be null " );
            }

            PublicId = Guid.NewGuid();
            UserId = userId;
            CreatedDate = DateTime.Now;
        }

        public void AddProduct( Product product )
        {
            if ( product == null )
            {
                throw new ArgumentException( $"{nameof( product )} can not be null" );
            }

            CartItem cartItem = new CartItem( PublicId, product.PublicId );
            CartItems.Add( cartItem );
        }

        public void RemoveProduct( Guid productId )
        {
            if ( productId == Guid.Empty )
            {
                throw new ArgumentException( $"{nameof( productId )} can not be empty" );
            }

            CartItem item = CartItems.FirstOrDefault( ci => ci.ProductId == productId );
            if ( item == null )
            {
                throw new ArgumentException( $"{nameof( item )} item was not found" );
            }

            CartItems.Remove( item );
        }

        public void UpdateProductQuantity( Guid productId, int quantity )
        {
            CartItem product = CartItems.FirstOrDefault( ci => ci.ProductId == productId );
            if ( product == null )
            {
                throw new ArgumentException( $"{nameof( product )} product was not found" );
            }

            product.SetQuantity( quantity );
        }
    }
}