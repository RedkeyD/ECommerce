using Application.Interfaces;
using Application.Products;
using Domain.Entities;

namespace Application.Carts.Commands.AddProductToCart;

public class AddProductToCartCommandHandler
{
    private readonly ICartRepository _cartRepository;
    private readonly IProductRepository _productRepository;
    private readonly IValidator _addProductToCartCommandValidator;

    public AddProductToCartCommandHandler( ICartRepository cartRepository, IProductRepository productRepository, IValidator addProductToCartCommandValidator; )
    {
        _cartRepository = cartRepository;
        _productRepository = productRepository;
        _addProductToCartCommandValidator = addProductToCartCommandValidator;
    }

    public async Task Handle( AddProductToCartCommand command )
    {
        Cart cart = await _cartRepository.GetByIdAsync( command.CartId );

        Product product = await _productRepository.GetByIdAsync( command.ProductId );



        cart.AddProduct( product, command.Quantity );

        await _cartRepository.UpdateAsync( cart );
    }
}