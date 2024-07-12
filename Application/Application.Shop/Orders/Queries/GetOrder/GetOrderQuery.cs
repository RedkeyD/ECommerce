using Application.Abstractions.Messaging;

namespace Application.Orders.Queries.GetOrder
{
    public class GetOrderQuery : IQuery<GetOrderQueryResult>
    {
        public Guid OrderId { get; set; }
    }
}