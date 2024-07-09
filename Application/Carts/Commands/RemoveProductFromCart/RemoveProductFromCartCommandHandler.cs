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
        Cart cart = await _cartRepository.GetByIdAsync( command.CartId );

        cart.RemoveProduct( command.ProductId );

        await _cartRepository.UpdateAsync( cart );
    }
}
