using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Users.Queries.GetUser;

public class GetUserQueryHandler
{
    private readonly IUserRepository _userRepository;

    public GetUserQueryHandler( IUserRepository userRepository )
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle( GetUserQuery query )
    {
        GetUserQueryValidator.ValidateUserId( query.UserId );

        User user = await _userRepository.GetByIdAsync( query.UserId );

        GetUserQueryValidator.ValidateUser( user );

        return user;
    }
}