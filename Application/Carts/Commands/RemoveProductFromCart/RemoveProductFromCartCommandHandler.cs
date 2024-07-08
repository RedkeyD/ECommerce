using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Carts.Commands.RemoveProductFromCart;

public class RemoveProductFromCartCommandHandler
{
    private readonly ICartRepository _cartRepository;

    public RemoveProductFromCartCommandHandler( ICartRepository cartRepository )
    {
        _cartRepository = cartRepository;
    }

    public async Task Handle( RemoveProductFromCartCommand command )
    {
        RemoveProductFromCartCommandValidator.ValidateCartId( command.CartId );
        RemoveProductFromCartCommandValidator.ValidateProductId( command.ProductId );

        Cart cart = await _cartRepository.GetByIdAsync( command.CartId );

        RemoveProductFromCartCommandValidator.ValidateCart( cart );

        cart.RemoveProduct( command.ProductId );

        await _cartRepository.UpdateAsync( cart );
    }
}
