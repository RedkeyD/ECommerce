using Domain.Entities;
using MediatR;


namespace Application.Orders.Queries.GetOrder;

public class GetOrderQuery : IRequest<Order>
{
    public Guid OrderId { get; }

    public GetOrderQuery( Guid orderId )
    {
        GetOrderQueryValidator.ValidateOrderId(orderId);

        OrderId = orderId;
    }
}