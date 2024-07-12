using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Application.Shop.Carts.Dtos;
using Domain.Entities;

namespace Application.Carts.Queries.GetCart
{
    public class GetCartQueryHandler
    {
        private readonly ICartRepository _repository;
        private readonly IAsyncValidator<GetCartQuery> _queryValidator;

        public GetCartQueryHandler( ICartRepository repository, IAsyncValidator<GetCartQuery> queryValidator )
        {
            _repository = repository;
            _queryValidator = queryValidator;
        }

        public async Task<GetCartQueryResult> Handle( GetCartQuery request, CancellationToken cancellationToken )
        {
            Result validationResult = await _queryValidator.ValidateAsync( request );
            if ( validationResult.IsFailure )
            {
                return GetCartQueryResult.Fail( validationResult.Error );
            }

            Cart cart = await _repository.GetByIdAsync( request.CartId );
            CartDto cartDto = cart.MapToDto();

            return GetCartQueryResult.Ok( cartDto );
        }
    }
}