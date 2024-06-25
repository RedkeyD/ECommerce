namespace Domain.Entities;

public class Role
{
    public Guid Id { get; private init; }
    public string Name { get; private set; }

    public Role( string name )
    {
        if ( string.IsNullOrWhiteSpace( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or empty.", nameof( name ) );
        }

        Id = Guid.NewGuid();
        Name = name;
    }

    public void SetName( string name )
    {
        if ( string.IsNullOrWhiteSpace( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or empty.", nameof( name ) );
        }

        Name = name;
    }
}