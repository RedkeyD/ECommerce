namespace Domain.Entities;

public class User
{
    public Guid UserId { get; private init; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public string Role { get; private set; }
    public ICollection<Order> Orders { get; private set; } = new List<Order>();
    public ICollection<Review> Reviews { get; private set; } = new List<Review>();
    public ShoppingCart ShoppingCart { get; private set; }

    public User( string username, string email, string passwordHash, string role )
    {
        if ( string.IsNullOrEmpty( username ) )
        {
            throw new ArgumentException( $"'{nameof( username )}' cannot be null or empty.", nameof( username ) );
        }

        if ( string.IsNullOrEmpty( email ) )
        {
            throw new ArgumentException( $"'{nameof( email )}' cannot be null or empty.", nameof( email ) );
        }

        if ( string.IsNullOrEmpty( passwordHash ) )
        {
            throw new ArgumentException( $"'{nameof( passwordHash )}' cannot be null or empty.", nameof( passwordHash ) );
        }

        if ( string.IsNullOrEmpty( role ) )
        {
            throw new ArgumentException( $"'{nameof( role )}' cannot be null or empty.", nameof( role ) );
        }

        UserId = Guid.NewGuid();
        Username = username;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }

    private User() { }

    public void SetUsername( string username )
    {
        if ( string.IsNullOrEmpty( username ) )
        {
            throw new ArgumentException( $"'{nameof( username )}' cannot be null or empty.", nameof( username ) );
        }

        Username = username;
    }

    public void SetEmail( string email )
    {
        if ( string.IsNullOrEmpty( email ) )
        {
            throw new ArgumentException( $"'{nameof( email )}' cannot be null or empty.", nameof( email ) );
        }

        Email = email;
    }

    public void SetPasswordHash( string passwordHash )
    {
        if ( string.IsNullOrEmpty( passwordHash ) )
        {
            throw new ArgumentException( $"'{nameof( passwordHash )}' cannot be null or empty.", nameof( passwordHash ) );
        }

        PasswordHash = passwordHash;
    }

    public void SetRole( string role )
    {
        if ( string.IsNullOrEmpty( role ) )
        {
            throw new ArgumentException( $"'{nameof( role )}' cannot be null or empty.", nameof( role ) );
        }

        Role = role;
    }
}

