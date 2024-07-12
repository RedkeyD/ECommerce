using Domain.Enums;

namespace Domain.Entities
{
    public class Order
    {
        public long Id { get; }
        public Guid PublicId { get; }
        public Guid UserId { get; }
        public DateTime OrderDate { get; }
        public OrderStatus Status { get; private set; }
        public User User { get; }
        public ICollection<OrderItem> OrderItems { get; }

        public Order( Guid userId )
        {
            if ( userId == Guid.Empty )
            {
                throw new ArgumentException( $"'{nameof( userId )}' cannot be null " );
            }

            PublicId = Guid.NewGuid();
            UserId = userId;
            OrderDate = DateTime.Now;
            Status = OrderStatus.Created;
        }

        public void SetStatus( OrderStatus newStatus )
        {
            if ( newStatus != Status + 1 )
            {
                throw new InvalidOperationException( $"Cannot transition from {Status} to {newStatus}" );
            }

            Status = newStatus;
        }
    }
}