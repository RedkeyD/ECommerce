using Application.Foundation.Result;
using Application.Shop.Carts.Dtos;

namespace Application.Carts.Queries.GetCart
{
    public class GetCartQueryResult : Result<GetCartQueryResult, IReadOnlyList<CartDto>>
    {

    }
}