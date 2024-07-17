using Application.Abstractions.Messaging;

namespace Application.Users.Queries.GetUser
{
    public class GetUserQuery : IQuery<GetUserQueryResult>
    {
        public Guid UserId { get; }
    }
}