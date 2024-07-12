using Application.Abstractions.Validators;
using Application.Foundation.Result;

namespace Application.Orders.Queries.GetOrder
{
    public class GetOrderQueryValidator : IAsyncValidator<GetOrderQuery>
    {
        private IOrderRepository _orderRepository;

        public GetOrderQueryValidator( IOrderRepository orderRepository )
        {
            _orderRepository = orderRepository;
        }

        public async Task<Result> ValidateAsync( GetOrderQuery data )
        {
            if ( data.OrderId == default )
            {
                return Result.Fail( new Error( "Order cannot be empty", "Request.OrderId" ) );
            }

            bool isOrderExists = await _orderRepository.IsOrderExistsAsync( data.OrderId );
            if ( !isOrderExists )
            {
                return Result.Fail( new Error( "Order with this id is not exists", "Request.OrderId" ) );
            }

            return Result.Ok();
        }
    }
}