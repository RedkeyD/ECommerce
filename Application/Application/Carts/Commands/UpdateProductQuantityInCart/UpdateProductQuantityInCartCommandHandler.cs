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
        Cart cart = await _cartRepository.GetByIdAsync( command.CartId );

        cart.UpdateProductQuantity( command.ProductId, command.Quantity );

        await _cartRepository.UpdateAsync( cart );
    }
}
