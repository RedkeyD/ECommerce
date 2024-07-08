using Application.Interfaces.Repositories;
using Domain.Entities;

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
        GetProductQueryValidator.ValidateProductId(query.ProductId);

        Product product = await _productRepository.GetByIdAsync( query.ProductId );

        GetProductQueryValidator.ValidateProduct(product);

        return product;
    }
}
