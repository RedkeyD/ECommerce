namespace Domain.Entities;

public class User
{
    public Guid Id { get; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public ICollection<Order> Orders { get; private set; }
    public ICollection<UserRole> UserRoles { get; private set; }
    public Cart ShoppingCart { get; private set; }

    public User( string username, string email, string passwordHash )
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

        Id = Guid.NewGuid();
        Username = username;
        Email = email;
        PasswordHash = passwordHash;
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

}

