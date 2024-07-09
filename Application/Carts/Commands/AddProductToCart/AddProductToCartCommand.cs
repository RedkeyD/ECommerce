namespace Application.Carts.Commands.AddProductToCart;

public sealed record AddProductToCartCommand( Guid CartId, Guid ProductId, int Quantity );