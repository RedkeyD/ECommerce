namespace Domain.Entities;

public class Category
{
    public Guid Id { get; private init; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ICollection<Product> Products { get; private set; } = new List<Product>();

    public Category( string name, string description )
    {
        if ( string.IsNullOrWhiteSpace( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or empty.", nameof( name ) );
        }

        if ( string.IsNullOrWhiteSpace( description ) )
        {
            throw new ArgumentException( $"'{nameof( description )}' cannot be null or empty.", nameof( description ) );
        }

        Id = Guid.NewGuid();
        Name = name;
        Description = description;
    }

    public void SetName( string name )
    {
        if ( string.IsNullOrWhiteSpace( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or empty.", nameof( name ) );
        }

        Name = name;
    }

    public void SetDescription( string description )
    {
        if ( string.IsNullOrWhiteSpace( description ) )
        {
            throw new ArgumentException( $"'{nameof( description )}' cannot be null or empty.", nameof( description ) );
        }

        Description = description;
    }
}
