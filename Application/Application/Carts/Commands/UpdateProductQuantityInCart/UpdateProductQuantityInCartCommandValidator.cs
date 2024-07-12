using Domain.Abstractions;
using Domain.Entities;
using Domain.Errors;

namespace Application.Carts.Commands.UpdateProductQuantityInCart;

public class UpdateProductQuantityInCartCommandValidator
{
    public Result Validate( Guid cartId, Guid productId, int quantity, Cart cart )
    {
        if ( cartId == Guid.Empty )
        {
            return CartErrors.EmptyCartId;
        }

        if ( productId == Guid.Empty )
        {
            return CartErrors.EmptyProductId;
        }

        if ( quantity <= 0 )
        {
            return CartErrors.NegativeProductQuantity;
        }

        if ( cart == null )
        {
           return CartErrors.CartNotFound;
        }

        return Result.Success();
    }
}