using Application.Users.Queries.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ShopApi.Controllers
{
    [ApiController]
    [Route( "api/[controller]" )]
    public class UsersController : ControllerBase
    {
        private readonly ISender _sender;

        public UsersController( ISender sender )
        {
            _sender = sender;
        }

        [HttpGet( "{id}" )]
        public async Task<IActionResult> GetUser( Guid id )
        {
            var user = await _sender.Send( new GetUserQuery( id ) );

            return Ok( user );
        }
    }
}
