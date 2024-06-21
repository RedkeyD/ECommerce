namespace Domain.Entities;

public class Product
{
    public Guid ProductId { get; private init; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int StockQuantity { get; private set; }
    public Guid CategoryId { get; private set; }
    public string ImageUrl { get; private set; }
    public Category Category { get; private set; }
    public ICollection<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();
    public ICollection<Review> Reviews { get; private set; } = new List<Review>();

    public Product( string name, string description, decimal price, int stockQuantity, Guid categoryId, string imageUrl )
    {
        if ( string.IsNullOrEmpty( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or empty.", nameof( name ) );
        }

        if ( string.IsNullOrEmpty( description ) )
        {
            throw new ArgumentException( $"'{nameof( description )}' cannot be null or empty.", nameof( description ) );
        }

        if ( price <= 0 )
        {
            throw new ArgumentException( $"'{nameof( price )}' must be greater than zero.", nameof( price ) );
        }

        if ( stockQuantity < 0 )
        {
            throw new ArgumentException( $"'{nameof( stockQuantity )}' cannot be negative.", nameof( stockQuantity ) );
        }

        if ( string.IsNullOrEmpty( imageUrl ) )
        {
            throw new ArgumentException( $"'{nameof( imageUrl )}' cannot be null or empty.", nameof( imageUrl ) );
        }

        ProductId = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        StockQuantity = stockQuantity;
        CategoryId = categoryId;
        ImageUrl = imageUrl;
    }

    private Product() { }

    public void SetName( string name )
    {
        if ( string.IsNullOrEmpty( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or empty.", nameof( name ) );
        }

        Name = name;
    }

    public void SetDescription( string description )
    {
        if ( string.IsNullOrEmpty( description ) )
        {
            throw new ArgumentException( $"'{nameof( description )}' cannot be null or empty.", nameof( description ) );
        }

        Description = description;
    }

    public void SetPrice( decimal price )
    {
        if ( price <= 0 )
        {
            throw new ArgumentException( $"'{nameof( price )}' must be greater than zero.", nameof( price ) );
        }

        Price = price;
    }

    public void SetStockQuantity( int stockQuantity )
    {
        if ( stockQuantity < 0 )
        {
            throw new ArgumentException( $"'{nameof( stockQuantity )}' cannot be negative.", nameof( stockQuantity ) );
        }

        StockQuantity = stockQuantity;
    }

    public void SetCategoryId( Guid categoryId )
    {
        CategoryId = categoryId;
    }

    public void SetImageUrl( string imageUrl )
    {
        if ( string.IsNullOrEmpty( imageUrl ) )
        {
            throw new ArgumentException( $"'{nameof( imageUrl )}' cannot be null or empty.", nameof( imageUrl ) );
        }

        ImageUrl = imageUrl;
    }
}
