namespace ECommerce.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    AuthenticationResponse Register( string username, string email, string password )
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            username,
            email,
            "token" );
    }

    AuthenticationResponse Login(string password, string email )
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "Andrey",
            email,
            "token" );
    }
}