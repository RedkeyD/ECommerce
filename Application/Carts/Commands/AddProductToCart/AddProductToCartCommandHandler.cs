using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Carts.Commands.AddProductToCart;

public class AddProductToCartCommandHandler
{
    private readonly ICartRepository _cartRepository;
    private readonly IProductRepository _productRepository;

    public AddProductToCartCommandHandler( ICartRepository cartRepository, IProductRepository productRepository )
    {
        _cartRepository = cartRepository;
        _productRepository = productRepository;
    }

    public async Task Handle( AddProductToCartCommand command )
    {
        AddProductToCartCommandValidator.ValidateCartId( command.CartId );
        AddProductToCartCommandValidator.ValidateProductId( command.ProductId );
        AddProductToCartCommandValidator.ValidateQuantity( command.Quantity );

        Cart cart = await _cartRepository.GetByIdAsync( command.CartId );

        AddProductToCartCommandValidator.ValidateCart( cart );

        Product product = await _productRepository.GetByIdAsync( command.ProductId );

        AddProductToCartCommandValidator.ValidateProduct( product );

        cart.AddProduct( product, command.Quantity );

        await _cartRepository.UpdateAsync( cart );
    }
}
