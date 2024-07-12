using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Application.Products;

namespace Application.Carts.Commands.AddProductToCart
{
    internal class AddProductToCartCommandValidator : IAsyncValidator<AddProductToCartCommand>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;

        public AddProductToCartCommandValidator( ICartRepository cartRepository, IProductRepository productRepository )
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
        }

        public async Task<Result> ValidateAsync( AddProductToCartCommand data )
        {
            if ( data.CartId == Guid.Empty )
            {
                return Result.Fail( new Error( "Cart with this id is not exists", "Request.CartId" ) );
            }

            if ( data.ProductId == Guid.Empty )
            {
                return Result.Fail( new Error( "Product with this id is not exists", "Request.ProductId" ) );
            }

            bool isCartExists = await _cartRepository.IsCartExistsAsync( data.CartId );
            if ( !isCartExists )
            {
                return Result.Fail( new Error( "Cart with this id is not exists", "Request.CartId" ) );
            }

            bool isProductExists = await _productRepository.IsProductExistsAsync( data.ProductId );
            if ( !isProductExists )
            {
                return Result.Fail( new Error( "product with this id is not exists", "Request.ProductId" ) );
            }

            return Result.Ok();
        }
    }
}