using Application.Abstractions;
using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Domain.Entities;

namespace Application.Carts.Commands.RemoveProductFromCart
{
    public class RemoveProductFromCartCommandHandler
    {
        private readonly ICartRepository _cartRepository;
        private readonly IAsyncValidator<RemoveProductFromCartCommand> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveProductFromCartCommandHandler(
            ICartRepository cartRepository,
            IAsyncValidator<RemoveProductFromCartCommand> validator,
            IUnitOfWork unitOfWork )
        {
            _cartRepository = cartRepository;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }
        public async Task<Result> Handle( RemoveProductFromCartCommand command, CancellationToken cancellationToken )
        {
            Result validationResult = await _validator.ValidateAsync( command );
            if ( validationResult.IsFailure )
            {
                return validationResult;
            }

            Cart cart = await _cartRepository.GetByIdAsync( command.CartId );

            cart.RemoveProduct( command.ProductId );

            await _cartRepository.UpdateAsync( cart );

            return Result.Ok();
        }
    }
}