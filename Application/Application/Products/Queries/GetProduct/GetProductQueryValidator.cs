using Domain.Entities;

namespace Application.Products.Queries.GetProduct;

public static class GetProductQueryValidator
{
    public static void ValidateProductId( Guid productId )
    {
        if ( productId == Guid.Empty )
        {
            throw new ArgumentException( "product ID cannot be empty", nameof( productId ) );
        }
    }

    public static void ValidateProduct( Product product )
    {
        if ( product == null )
        {
            throw new Exception( "product not found" );
        }
    }
}