using Application.Shop.Users.Dtos;

namespace Application.Shop.Users.Extensions
{
    internal static class UserDtoMappingExtensions
    {
        public static UserDto MapToDto( this UserDto userDto )
        {
            return new UserDto( userDto.Orders, userDto.Cart, userDto.Username, userDto.Email );
        }
    }
}