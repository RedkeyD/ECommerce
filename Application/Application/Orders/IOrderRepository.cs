using Domain.Entities;

namespace Application.Orders
{
    public interface IOrderRepository
    {
        Task<bool> IsOrderExistsAsync( Guid CartPublicId );
        Task<Order> GetByIdAsync( Guid orderId );
    }
}