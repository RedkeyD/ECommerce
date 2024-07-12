using Domain.Entities;
using MediatR;

namespace Application.Products.Queries.GetProduct
{
    public class GetProductQuery : IRequest<Product>
    {
        public Guid ProductId { get; }

        public GetProductQuery( Guid productId )
        {
            GetProductQueryValidator.ValidateProductId( productId );

            ProductId = productId;
        }
    }
}