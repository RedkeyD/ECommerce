namespace Application.Carts.Queries.GetCart;

using Domain.Entities;
using MediatR;

public class GetCartQuery : IRequest<Cart>
{
    public Guid CartId { get; }

    public GetCartQuery( Guid cartId )
    {
        CartId = cartId;
    }
}