using Application.Abstractions.Messaging;
using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Application.Shop.Categories.Extensions;
using Application.Shop.Orders.Dtos;
using Application.Shop.Orders.Extensions;
using Domain.Entities;

namespace Application.Orders.Queries.GetOrder
{
    public class GetOrderQueryHandler : IQueryHandler<GetOrderQuery, GetOrderQueryResult>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IAsyncValidator<GetOrderQuery> _queryValidator;

        public GetOrderQueryHandler( IOrderRepository orderRepository, IAsyncValidator<GetOrderQuery> queryValidator )
        {
            _orderRepository = orderRepository;
            _queryValidator = queryValidator;
        }

        public async Task<GetOrderQueryResult> Handle( GetOrderQuery request, CancellationToken cancellationToken )
        {
            Result validationResult = await _queryValidator.ValidateAsync( request );
            if ( validationResult.IsFailure )
            {
                return GetOrderQueryResult.Fail( validationResult.Error );
            }

            Order order = await _orderRepository.GetByIdAsync( request.OrderId );
            OrderDto OrderDto = order.MapToDto();

            return GetOrderQueryResult.Ok( OrderDto );
        }
    }
}