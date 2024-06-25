namespace Domain.Entities;

public class Order
{
    public Guid Id { get; private init; }
    public Guid UserId { get; private set; }
    public DateTime OrderDate { get; private set; }
    public string Status { get; private set; }
    public decimal TotalAmount { get; private set; }
    public User User { get; private set; }
    public ICollection<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();

    public Order( Guid userId, string status, decimal totalAmount )
    {

        if ( string.IsNullOrWhiteSpace( status ) )
        {
            throw new ArgumentException( $"'{nameof( status )}' cannot be null or empty.", nameof( status ) );
        }

        if ( totalAmount <= 0 )
        {
            throw new ArgumentException( $"'{nameof( totalAmount )}' must be greater than zero.", nameof( totalAmount ) );
        }

        Id = Guid.NewGuid();
        UserId = userId;
        OrderDate = DateTime.Now;
        Status = status;
        TotalAmount = totalAmount;
    }

    public void SetStatus( string status )
    {
        if ( string.IsNullOrWhiteSpace( status ) )
        {
            throw new ArgumentException( $"'{nameof( status )}' cannot be null or empty.", nameof( status ) );
        }

        Status = status;
    }

    public void SetTotalAmount( decimal totalAmount )
    {
        if ( totalAmount <= 0 )
        {
            throw new ArgumentException( $"'{nameof( totalAmount )}' must be greater than zero.", nameof( totalAmount ) );
        }

        TotalAmount = totalAmount;
    }
}