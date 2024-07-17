using Application.Abstractions.Validators;
using Application.Foundation.Result;

namespace Application.Carts.Queries.GetCart
{
    internal class GetCartQueryValidator : IAsyncValidator<GetCartQuery>
    {
        private ICartRepository _cartRepository;

        public GetCartQueryValidator( ICartRepository cartRepository )
        {
            _cartRepository = cartRepository;
        }

        public async Task<Result> ValidateAsync( GetCartQuery data )
        {
            if ( data.CartId == Guid.Empty )
            {
                return Result.Fail( new Error( "Cart cannot be empty", "Request.CartId" ) );
            }

            bool isCartExists = await _cartRepository.IsCartExistsAsync( data.CartId );
            if ( !isCartExists )
            {
                return Result.Fail( new Error( "Cart with this id is not exists", "Request.CartId" ) );
            }

            return Result.Ok();
        }
    }
}