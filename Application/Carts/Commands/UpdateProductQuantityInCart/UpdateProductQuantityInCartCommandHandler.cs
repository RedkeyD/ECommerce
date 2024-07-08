using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Carts.Commands.UpdateProductQuantityInCart;

public class UpdateProductQuantityInCartCommandHandler
{
    private readonly ICartRepository _cartRepository;

    public UpdateProductQuantityInCartCommandHandler( ICartRepository cartRepository )
    {
        _cartRepository = cartRepository;
    }

    public async Task Handle( UpdateProductQuantityInCartCommand command )
    {
        UpdateProductQuantityInCartCommandValidator.ValidateCartId( command.CartId );
        UpdateProductQuantityInCartCommandValidator.ValidateProductId( command.ProductId );
        UpdateProductQuantityInCartCommandValidator.ValidateQuantity( command.Quantity );

        Cart cart = await _cartRepository.GetByIdAsync( command.CartId );

        UpdateProductQuantityInCartCommandValidator.ValidateCart( cart );

        cart.UpdateProductQuantity( command.ProductId, command.Quantity );

        await _cartRepository.UpdateAsync( cart );
    }
}
