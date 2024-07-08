using Domain.Entities;

namespace Application.Interfaces.Repositories;
public interface IOrderRepository
{
    Task<Order> GetByIdAsync( Guid orderId );
}
