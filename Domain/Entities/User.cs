namespace Domain.Entities;

public class User
{
    public Guid Id { get; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public ICollection<Order> Orders { get; }
    public ICollection<UserRole> UserRoles { get; }
    public Cart ShoppingCart { get; }

    public User( string username, string email, string password )
    {
        if ( string.IsNullOrWhiteSpace( username ) )
        {
            throw new ArgumentException( $"'{nameof( username )}' cannot be null or empty.", nameof( username ) );
        }

        if ( string.IsNullOrWhiteSpace( email ) )
        {
            throw new ArgumentException( $"'{nameof( email )}' cannot be null or empty.", nameof( email ) );
        }

        if ( string.IsNullOrWhiteSpace( password ) )
        {
            throw new ArgumentException( $"'{nameof( password )}' cannot be null or empty.", nameof( password ) );
        }

        Id = Guid.NewGuid();
        Username = username;
        Email = email;
        Password = password;
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

    public void SetPasswordHash( string password )
    {
        if ( string.IsNullOrWhiteSpace( password ) )
        {
            throw new ArgumentException( $"'{nameof( password )}' cannot be null or empty.", nameof( password ) );
        }

        Password = password;
    }
}