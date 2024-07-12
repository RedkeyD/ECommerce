using Application.Abstractions.Messaging;
using Application.Abstractions.Validators;
using Application.Foundation.Result;
using Application.Shop.Categories.Dtos;
using Application.Shop.Categories.Extensions;
using Domain.Entities;

namespace Application.Categories.Queries.GetCategory
{
    public class GetCategoryQueryHandler : IQueryHandler<GetCategoryQuery, GetCategoryQueryResult>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAsyncValidator<GetCategoryQuery> _queryValidator;

        public GetCategoryQueryHandler( ICategoryRepository categoryRepository, IAsyncValidator<GetCategoryQuery> queryValidator )
        {
            _categoryRepository = categoryRepository;
            _queryValidator = queryValidator;
        }

        public async Task<GetCategoryQueryResult> Handle( GetCategoryQuery request, CancellationToken cancellationToken )
        {
            Result validationResult = await _queryValidator.ValidateAsync( request );
            if ( validationResult.IsFailure )
            {
                return GetCategoryQueryResult.Fail( validationResult.Error );
            }

            Category category = await _categoryRepository.GetByIdAsync( request.CategoryId );
            CategoryDto categoryDto = category.MapToDto();

            return GetCategoryQueryResult.Ok( categoryDto );
        }
    }
}