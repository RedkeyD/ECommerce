namespace ECommerce.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResponse Login( string email, string password );
    AuthenticationResponse Refister( string username, string password, string email );
}