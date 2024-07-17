using Application.Abstractions.Messaging;
using Application.Foundation.Result;

namespace Application.Carts.Commands.RemoveProductFromCart
{
    public sealed record RemoveProductFromCartCommand( Guid CartId, Guid ProductId ) : ICommand<Result>;
}