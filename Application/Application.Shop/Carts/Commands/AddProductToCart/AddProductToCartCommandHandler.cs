using Application.Abstractions;
using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Application.Products;
using Domain.Entities;

namespace Application.Carts.Commands.AddProductToCart
{

    public class AddProductToCartCommandHandler
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IAsyncValidator<AddProductToCartCommand> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public AddProductToCartCommandHandler(
            ICartRepository cartRepository,
            IProductRepository productRepository,
            IAsyncValidator<AddProductToCartCommand> validator,
            IUnitOfWork unitOfWork )
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle( AddProductToCartCommand command, CancellationToken cancellationToken )
        {
            Result validationResult = await _validator.ValidateAsync( command );
            if ( validationResult.IsFailure )
            {
                return validationResult;
            }

            Cart cart = await _cartRepository.GetByIdAsync( command.CartId );
            Product product = await _productRepository.GetByIdAsync( command.ProductId );

            cart.AddProduct( product );

            await _cartRepository.UpdateAsync( cart );

            return Result.Ok();
        }
    }
}