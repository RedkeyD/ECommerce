using Application.Users;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ShopApi.Controllers
{
    [ApiController]
    [Route( "api/[controller]" )]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController( IUserRepository userService )
        {
            _userRepository = userService;
        }

        [HttpGet( "{id}" )]
        public async Task<IActionResult> GetUser( long id )
        {
            var user = await _userRepository.GetByIdAsync( id );

            return Ok( user );
        }
    }
}
