namespace Domain.Entities;

public class ShoppingCart
{
    public int CartId { get; private init; }
    public int UserId { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public ICollection<CartItem> CartItems { get; private set; } = new List<CartItem>();
    public User User { get; private set; }

    public ShoppingCart( int userId, DateTime createdDate )
    {
        if ( createdDate == default )
        {
            throw new ArgumentException( $"'{nameof( createdDate )}' cannot be default.", nameof( createdDate ) );
        }

        UserId = userId;
        CreatedDate = createdDate;
    }

    private ShoppingCart() { }
}
