using Domain.Abstractions;
using Domain.Entities;
using Domain.Errors;

namespace Application.Carts.Commands.RemoveProductFromCart;

public class RemoveProductFromCartCommandValidator
{
    public Result Validate( Guid cartId, Guid productId, Cart cart )
    {
        if ( cartId == Guid.Empty )
        {
            return CartErrors.EmptyCartId;
        }

        if ( productId == Guid.Empty )
        {
            return CartErrors.EmptyProductId;
        }

        if ( cart == null )
        {
            return CartErrors.CartNotFound;
        }

        return Result.Success();
    }
}