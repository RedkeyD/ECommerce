using Application.Abstractions.Messaging;
using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Application.Shop.Orders.Extensions;
using Application.Shop.Products.Dtos;
using Application.Shop.Products.Extensions;
using Domain.Entities;

namespace Application.Products.Queries.GetProduct
{
    public class GetProductQueryHandler : IQueryHandler<GetProductQuery, GetProductQueryResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly IAsyncValidator<GetProductQuery> _queryValidator;

        public GetProductQueryHandler( IProductRepository productRepository, IAsyncValidator<GetProductQuery> queryValidator )
        {
            _productRepository = productRepository;
            _queryValidator = queryValidator;
        }

        public async Task<GetProductQueryResult> Handle( GetProductQuery request, CancellationToken cancellationToken )
        {
            Result validationResult = await _queryValidator.ValidateAsync( request );
            if ( validationResult.IsFailure )
            {
                return GetProductQueryResult.Fail( validationResult.Error );
            }

            Product product = await _productRepository.GetByIdAsync( request.ProductId );
            ProductDto productDto = product.MapToDto();

            return GetProductQueryResult.Ok( productDto );
        }
    }
}