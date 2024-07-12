namespace Application.Carts.Commands.RemoveProductFromCart
{
    public sealed record RemoveProductFromCartCommand( Guid CartId, Guid ProductId );
}