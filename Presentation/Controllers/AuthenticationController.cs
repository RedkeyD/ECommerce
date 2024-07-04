using Microsoft.AspNetCore.Mvc;

namespace EComerce.Presentation.Controllers;


[ApiController]
[Route( "auth" )]
public class AuthenticationController : ControllerBase
{
    public AuthenticationController( IAuthenticationService authenticationService )
    {
        _authenticationService = authenticationService;
    }
    private readonly IAuthenticationService _authenticationService;

    [HttpPost( "Register" )]
    public IActionResult Register( RegisterRequest request )
    {
        var authResult = _authenticationService.Register(
            request.Username,
            request.Email,
            request.Password );

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.USername,
            authResult.Email,
            authResult.Token );

        return Ok( request );
    }

    [HttpPost( "Login" )]
    public IActionResult Login( LoginRequest request )
    {
        var authResult = _authenticationService.Register(
            request.Email,
            request.Password );

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.USername,
            authResult.Email,
            authResult.Token );

        return Ok( request );
    }
}
