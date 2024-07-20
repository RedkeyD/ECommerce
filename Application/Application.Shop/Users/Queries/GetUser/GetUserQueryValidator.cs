using Application.Abstractions.Validators;
using Application.Foundation.Result;

namespace Application.Users.Queries.GetUser
{
    public class GetUserQueryValidator : IAsyncValidator<GetUserQuery>
    {
        private IUserRepository _userRepository;

        public GetUserQueryValidator( IUserRepository userRepository )
        {
            _userRepository = userRepository;
        }

        public async Task<Result> ValidateAsync( GetUserQuery data )
        {
            if ( data.UserId == null )
            {
                return Result.Fail( new Error( "User cannot be empty", "Request.UserId" ) );
            }

            bool isUserExists = await _userRepository.IsUserExistsAsync( data.UserId );
            if ( !isUserExists )
            {
                return Result.Fail( new Error( "User with this id is not exists", "Request.UserId" ) );
            }

            return Result.Ok();
        }
    }
}