using Application.Shop.Users.Dtos;
using Domain.Entities;

namespace Application.Shop.Users.Extensions
{
    internal static class UserDtoMappingExtensions
    {
        public static UserDto MapToDto( this User user )
        {
            return new UserDto( user.Orders, user.Cart, user.Username, user.Email );
        }
    }
}