﻿using Application.Abstractions;
using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Domain.Entities;

namespace Application.Carts.Commands.UpdateProductQuantityInCart
{
    public class UpdateProductQuantityInCartCommandHandler
    {
        private readonly ICartRepository _cartRepository;
        private readonly IAsyncValidator<UpdateProductQuantityInCartCommand> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductQuantityInCartCommandHandler(
            ICartRepository cartRepository,
            IAsyncValidator<UpdateProductQuantityInCartCommand> validator,
            IUnitOfWork unitOfWork )
        {
            _cartRepository = cartRepository;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle( UpdateProductQuantityInCartCommand command, CancellationToken cancellationToken )
        {
            Result validationResult = await _validator.ValidateAsync( command );
            if ( validationResult.IsFailure )
            {
                return validationResult;
            }

            Cart cart = await _cartRepository.GetByIdAsync( command.CartId );

            cart.UpdateProductQuantity( command.ProductId, command.Quantity );

            await _cartRepository.UpdateAsync( cart );

            return Result.Ok();
        }
    }
}