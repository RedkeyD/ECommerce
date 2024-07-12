using Domain.Entities;
using MediatR;

namespace Application.Carts.Queries.GetCart;

public class GetCartQuery : IRequest<Cart>
{
    public Guid CartId { get; }

    public GetCartQuery( Guid cartId )
    {
        CartId = cartId;
    }
}