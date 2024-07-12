using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Application.Products;

namespace Application.Carts.Commands.UpdateProductQuantityInCart
{
    internal class UpdateProductQuantityInCarCommandValidator : IAsyncValidator<UpdateProductQuantityInCartCommand>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;

        public UpdateProductQuantityInCarCommandValidator( ICartRepository cartRepository, IProductRepository productRepository )
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
        }

        public async Task<Result> ValidateAsync( UpdateProductQuantityInCartCommand data )
        {
            if ( data.CartId == Guid.Empty )
            {
                return Result.Fail( new Error( "Empty cartID", "Request.CartId" ) );
            }

            if ( data.ProductId == Guid.Empty )
            {
                return Result.Fail( new Error( "Empty productID", "Request.ProductId" ) );
            }

            if ( data.Quantity <= 0 )
            {
                return Result.Fail( new Error( "Quantity can not be lower than 0", "Request.Quantity" ) );
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