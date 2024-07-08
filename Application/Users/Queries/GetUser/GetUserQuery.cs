using Domain.Entities;
using MediatR;

namespace Application.Users.Queries.GetUser;

public class GetUserQuery : IRequest<User>
{
    public Guid UserId { get; }

    public GetUserQuery( Guid userId )
    {
        GetUserQueryValidator.ValidateUserId( userId );

        UserId = userId;
    }
}