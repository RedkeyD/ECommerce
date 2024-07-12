using Domain.Entities;

namespace Application.Users.Queries.GetUser
{
    public static class GetUserQueryValidator
    {
        public static void ValidateUserId( Guid userId )
        {
            if ( userId == Guid.Empty )
            {
                throw new ArgumentException( "user ID cannot be empty", nameof( userId ) );
            }
        }

        public static void ValidateUser( User user )
        {
            if ( user == null )
            {
                throw new Exception( "user not found" );
            }
        }
    }
}