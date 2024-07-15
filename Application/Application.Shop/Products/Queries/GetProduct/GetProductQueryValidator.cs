using Application.Abstractions.Validators;
using Application.Foundation.Result;

namespace Application.Products.Queries.GetProduct
{
    public class GetProductQueryValidator : IAsyncValidator<GetProductQuery>
    {
        private IProductRepository _productRepository;

        public GetProductQueryValidator( IProductRepository productRepository )
        {
            _productRepository = productRepository;
        }

        public async Task<Result> ValidateAsync( GetProductQuery data )
        {
            if ( data.ProductId == Guid.Empty )
            {
                return Result.Fail( new Error( "Product cannot be empty", "Request.ProductId" ) );
            }

            bool isProductExists = await _productRepository.IsProductExistsAsync( data.ProductId );
            if ( !isProductExists )
            {
                return Result.Fail( new Error( "Product with this id is not exists", "Request.ProductId" ) );
            }

            return Result.Ok();
        }
    }
}