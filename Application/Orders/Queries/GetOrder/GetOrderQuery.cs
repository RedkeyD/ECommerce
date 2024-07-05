namespace Application.Orders.Queries.GetOrder;

using Domain.Entities;
using MediatR;

public class GetOrderQuery : IRequest<Order>
{
    public Guid OrderId { get; }

    public GetOrderQuery(Guid orderId)
    {
        OrderId = orderId;
    }
}