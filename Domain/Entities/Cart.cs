namespace Domain.Entities;

public class Cart
{
    public Guid Id { get; private init; }
    public Guid UserId { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public ICollection<CartItem> CartItems { get; private set; } = new List<CartItem>();
    public User User { get; private set; }

    public Cart( Guid userId )
    {
        Id = Guid.NewGuid();
        UserId = userId;
        CreatedDate = DateTime.Now;
    }
}