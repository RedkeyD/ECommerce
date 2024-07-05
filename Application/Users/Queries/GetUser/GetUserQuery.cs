namespace Application.Users.Queries.GetUser;

using Domain.Entities;
using MediatR;

public class GetUserQuery : IRequest<User>
{
    public Guid UserId { get; }

    public GetUserQuery(Guid userId)
    {
        UserId = userId;
    }
}