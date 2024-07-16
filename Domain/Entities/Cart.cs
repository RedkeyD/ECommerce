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
    }
}