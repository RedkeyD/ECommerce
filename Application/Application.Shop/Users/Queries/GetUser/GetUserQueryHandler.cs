using Application.Abstractions.Messaging;
using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Application.Shop.Products.Extensions;
using Application.Shop.Users.Dtos;
using Application.Shop.Users.Extensions;
using Domain.Entities;

namespace Application.Users.Queries.GetUser
{
    public class GetUserQueryHandler : IQueryHandler<GetUserQuery, GetUserQueryResult>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAsyncValidator<GetUserQuery> _queryValidator;

        public GetUserQueryHandler( IUserRepository userRepository, IAsyncValidator<GetUserQuery> queryValidator )
        {
            _userRepository = userRepository;
            _queryValidator = queryValidator;
        }

        public async Task<GetUserQueryResult> Handle( GetUserQuery request, CancellationToken cancellationToken )
        {
            Result validationResult = await _queryValidator.ValidateAsync( request );
            if ( validationResult.IsFailure )
            {
                return GetUserQueryResult.Fail( validationResult.Error );
            }

            User user = await _userRepository.GetByIdAsync( request.UserId );
            UserDto userDto = user.MapToDto();

            return GetUserQueryResult.Ok( userDto );
        }
    }
}