using Application.Abstractions.Messaging;

namespace Application.Users.Queries.GetUser
{
    public record GetUserQuery( Guid UserId ) : IQuery<GetUserQueryResult>;
}