namespace Domain.Entities;

public class Order
{
    public Guid OrderId { get; private init; }
    public Guid UserId { get; private set; }
    public DateTime OrderDate { get; private set; }
    public string Status { get; private set; }
    public decimal TotalAmount { get; private set; }
    public User User { get; private set; }
    public ICollection<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();

    public Order( Guid userId, DateTime orderDate, string status, decimal totalAmount )
    {
        if ( orderDate == default )
        {
            throw new ArgumentException( $"'{nameof( orderDate )}' cannot be default.", nameof( orderDate ) );
        }

        if ( string.IsNullOrEmpty( status ) )
        {
            throw new ArgumentException( $"'{nameof( status )}' cannot be null or empty.", nameof( status ) );
        }

        if ( totalAmount <= 0 )
        {
            throw new ArgumentException( $"'{nameof( totalAmount )}' must be greater than zero.", nameof( totalAmount ) );
        }

        OrderId = Guid.NewGuid();
        UserId = userId;
        OrderDate = orderDate;
        Status = status;
        TotalAmount = totalAmount;
    }

    private Order() { }

    public void SetStatus( string status )
    {
        if ( string.IsNullOrEmpty( status ) )
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