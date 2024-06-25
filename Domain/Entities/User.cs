namespace Domain.Entities;

public class User
{
    public Guid Id { get; private init; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public Role Role { get; private set; }
    public ICollection<Order> Orders { get; private set; } = new List<Order>();
    public Cart ShoppingCart { get; private set; }

    public User( string username, string email, string passwordHash, Role role )
    {
        if ( string.IsNullOrWhiteSpace( username ) )
        {
            throw new ArgumentException( $"'{nameof( username )}' cannot be null or empty.", nameof( username ) );
        }

        if ( string.IsNullOrWhiteSpace( email ) )
        {
            throw new ArgumentException( $"'{nameof( email )}' cannot be null or empty.", nameof( email ) );
        }

        if ( string.IsNullOrWhiteSpace( passwordHash ) )
        {
            throw new ArgumentException( $"'{nameof( passwordHash )}' cannot be null or empty.", nameof( passwordHash ) );
        }

        if ( string.IsNullOrWhiteSpace( role ) )
        {
            throw new ArgumentException( $"'{nameof( role )}' cannot be null or empty.", nameof( role ) );
        }

        Id = Guid.NewGuid();
        Username = username;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }

    public void SetUsername( string username )
    {
        if ( string.IsNullOrWhiteSpace( username ) )
        {
            throw new ArgumentException( $"'{nameof( username )}' cannot be null or empty.", nameof( username ) );
        }

        Username = username;
    }

    public void SetEmail( string email )
    {
        if ( string.IsNullOrWhiteSpace( email ) )
        {
            throw new ArgumentException( $"'{nameof( email )}' cannot be null or empty.", nameof( email ) );
        }

        Email = email;
    }

    public void SetPasswordHash( string passwordHash )
    {
        if ( string.IsNullOrWhiteSpace( passwordHash ) )
        {
            throw new ArgumentException( $"'{nameof( passwordHash )}' cannot be null or empty.", nameof( passwordHash ) );
        }

        PasswordHash = passwordHash;
    }

    public void SetRole( Role role )
    {
        if ( role == null )
        {
            throw new ArgumentException( $"'{nameof( role )}' cannot be null.", nameof( role ) );
        }

        Role = role;
    }
}

