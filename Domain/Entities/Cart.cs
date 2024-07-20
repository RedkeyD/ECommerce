namespace Domain.Entities
{
    public class Cart
    {
        public long Id { get; private set; }
        public Guid PublicId { get; }
        public long UserId { get; }
        public DateTime CreatedDate { get; }
        public ICollection<CartItem> CartItems { get; private set; }
        public User User { get; }

        public Cart( long userId )
        {
            if ( userId == null )
            {
                throw new ArgumentException( $"{nameof( userId )} can not be null " );
            }

            PublicId = Guid.NewGuid();
            UserId = userId;
            CreatedDate = DateTime.Now;
        }
    }
}