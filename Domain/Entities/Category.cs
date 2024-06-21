namespace Domain.Entities;

public class Category
{
    public Guid CategoryId { get; private init; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ICollection<Product> Products { get; private set; } = new List<Product>();

    public Category( string name, string description )
    {
        if ( string.IsNullOrEmpty( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or empty.", nameof( name ) );
        }

        if ( string.IsNullOrEmpty( description ) )
        {
            throw new ArgumentException( $"'{nameof( description )}' cannot be null or empty.", nameof( description ) );
        }

        CategoryId = Guid.NewGuid();
        Name = name;
        Description = description;
    }

    private Category() { }

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
}
