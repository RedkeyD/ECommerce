namespace Domain.Entities;

public class Product
{
    public Guid Id { get; private init; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public Guid CategoryId { get; private set; }
    public string ImageUrl { get; private set; }
    public Category Category { get; private set; }
    public ICollection<Review> Reviews { get; private set; } = new List<Review>();

    public Product( string name, string description, decimal price, int stockQuantity, Guid categoryId, string imageUrl )
    {
        if ( string.IsNullOrWhiteSpace( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or empty.", nameof( name ) );
        }

        if ( string.IsNullOrWhiteSpace( description ) )
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

        if ( string.IsNullOrWhiteSpace( imageUrl ) )
        {
            throw new ArgumentException( $"'{nameof( imageUrl )}' cannot be null or empty.", nameof( imageUrl ) );
        }

        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        CategoryId = categoryId;
        ImageUrl = imageUrl;
    }
}