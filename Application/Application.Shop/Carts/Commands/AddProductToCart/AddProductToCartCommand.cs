using Application.Abstractions.Messaging;
using Application.Foundation.Result;

namespace Application.Carts.Commands.AddProductToCart
{
    public sealed record AddProductToCartCommand( Guid CartId, Guid ProductId ) : ICommand<Result>;
}