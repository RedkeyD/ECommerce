namespace Application.Carts.Commands.UpdateProductQuantityInCart
{
    public sealed record UpdateProductQuantityInCartCommand( Guid CartId, Guid ProductId, int Quantity );
}
