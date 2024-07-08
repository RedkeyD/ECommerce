using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Orders.Queries.GetOrder;

public class GetOrderQueryHandler
{
    private readonly IOrderRepository _orderRepository;

    public GetOrderQueryHandler( IOrderRepository orderRepository )
    {
        _orderRepository = orderRepository;
    }

    public async Task<Order> Handle( GetOrderQuery query )
    {
        GetOrderQueryValidator.ValidateOrderId( query.OrderId );

        Order order = await _orderRepository.GetByIdAsync( query.OrderId );

        GetOrderQueryValidator.ValidateOrder( order );

        return order;
    }
}
