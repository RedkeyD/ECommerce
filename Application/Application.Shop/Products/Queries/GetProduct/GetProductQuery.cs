using Application.Abstractions.Messaging;

namespace Application.Products.Queries.GetProduct
{
    public class GetProductQuery : IQuery<GetProductQueryResult>
    {
        public Guid ProductId { get; set; }
    }
}