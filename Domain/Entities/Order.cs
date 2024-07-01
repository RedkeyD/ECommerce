using Domain.Enums;

namespace Domain.Entities;

public class Order
{
    public Guid Id { get; }
    public Guid UserId { get; }
    public DateTime OrderDate { get; }
    public OrderStatus Status { get; private set; }
    public User User { get; }
    public ICollection<OrderItem> OrderItems { get; private set; }

    public Order( Guid userId, OrderStatus status )
    {

        Id = Guid.NewGuid();
        UserId = userId;
        OrderDate = DateTime.Now;
        Status = status;
    }

    public void SetStatus( OrderStatus status )
    {

        Status = status;
    }
}