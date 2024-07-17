using Domain.Entities;

public class UserRole
{
    public Guid UserId { get; }
    public User User { get; }
    public string RoleId { get; }
    public Role Role { get; }

    public UserRole( Guid userId, string roleId )
    {
        if ( userId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( userId )}' cannot be null " );
        }

        if ( string.IsNullOrWhiteSpace( roleId ) )
        {
            throw new ArgumentException( $"'{nameof( roleId )}' cannot be empty " );
        }

        UserId = userId;
        RoleId = roleId;
    }
}