namespace Application.Products.Queries.GetProduct;

using Domain.Entities;
using MediatR;

public class GetProductQuery : IRequest<Product>
{
    public Guid ProductId { get; }

    public GetProductQuery( Guid productId )
    {
        GetProductQueryValidator.ValidateProductId( productId );

        ProductId = productId;
    }
}