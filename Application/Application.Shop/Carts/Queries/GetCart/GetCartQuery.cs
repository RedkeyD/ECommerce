using Application.Abstractions.Messaging;

namespace Application.Carts.Queries.GetCart
{
    public class GetCartQuery : IQuery<GetCartQueryResult>
    {
        public Guid CartId { get; set; }
    }
}