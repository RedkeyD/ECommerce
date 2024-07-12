using Domain.Entities;

namespace Application.Orders.Queries.GetOrder;

public static class GetOrderQueryValidator
{
    public static void ValidateOrderId( Guid orderId )
    {
        if ( orderId == Guid.Empty )
        {
            throw new ArgumentException( "category ID cannot be empty", nameof( orderId ) );
        }
    }

    public static void ValidateOrder( Order order )
    {
        if ( order == null )
        {
            throw new Exception( "order not found" );
        }
    }
}