namespace Domain.Entities;

public class Cart
{
    public Guid Id { get; }
    public Guid UserId { get; }
    public DateTime CreatedDate { get; }
    public ICollection<CartItem> CartItems { get; }
    public User User { get; }

    public Cart( Guid userId )
    {
        if ( userId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( userId )}' cannot be null " );
        }

        Id = Guid.NewGuid();
        UserId = userId;
        CreatedDate = DateTime.Now;
    }
}