using Domain.Entities;

namespace Application.Carts.Queries.GetCart;

public class GetCartQueryHandler
{
    private readonly ICartRepository _cartRepository;

    public GetCartQueryHandler( ICartRepository cartRepository )
    {
        _cartRepository = cartRepository;
    }

    public async Task<Cart> Handle( GetCartQuery query )
    {
        GetCartQueryValidator.ValidateCartId( query.CartId );

        Cart cart = await _cartRepository.GetByIdAsync( query.CartId );

        GetCartQueryValidator.ValidateCart( cart );

        return cart;
    }
}
