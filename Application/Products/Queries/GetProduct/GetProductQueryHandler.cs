using Domain.Entities;
using Application.Interfaces;

namespace Application.Products.Queries.GetProduct;

public class GetProductQueryHandler
{
    private readonly IProductRepository _productRepository;

    public GetProductQueryHandler( IProductRepository productRepository )
    {
        _productRepository = productRepository;
    }

    public async Task<Product> Handle( GetProductQuery query )
    {
        var product = await _productRepository.GetByIdAsync( query.ProductId );

        return product;
    }
}
