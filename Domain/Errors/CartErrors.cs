using Domain.Abstractions;

namespace Domain.Errors;

public static class CartErrors
{
    public static readonly Error EmptyCartId = new( "Cart.InvalidId", "Cart ID cannot be empty" );

    public static readonly Error EmptyProductId = new( "Product.InvalidId", "Product ID cannot be empty" );

    public static readonly Error NegativeProductQuantity = new( "Cart.NegativeProductQuantity", "Quantity must be greater than zero" );

    public static readonly Error CartNotFound = new( "Cart.NotFound", "Cart not found" );

    public static readonly Error ProductNotFound = new( "Cart.ProductNotFound", "Product not found" );
}