using Domain.Entities;

public class UserRole
{
    public Guid UserId { get; private set; }
    public User User { get; private set; }
    public string RoleId { get; private set; }
    public Role Role { get; private set; }

    public UserRole( User user, Role role )
    {
        User = user;
        Role = role; 
        UserId = user.Id;
        RoleId = role.Id;
    }
}

