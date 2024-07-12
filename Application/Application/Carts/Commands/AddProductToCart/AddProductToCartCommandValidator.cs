using Domain.Entities;
using Domain.Abstractions;
using Domain.Errors;

namespace Application.Carts.Commands.AddProductToCart;

public class AddProductToCartCommandValidator
{
    public Result Validate( Guid cartId, Guid productId, int quantity, Cart cart, Product product )
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

        if ( product == null )
        {
            return CartErrors.ProductNotFound;
        }

        return Result.Success();
    }
}