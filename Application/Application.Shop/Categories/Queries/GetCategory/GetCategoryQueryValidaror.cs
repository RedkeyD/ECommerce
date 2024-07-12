using Application.Abstractions.Validators;
using Application.Foundation.Result;

namespace Application.Categories.Queries.GetCategory
{
    public class GetCategoryQueryValidator : IAsyncValidator<GetCategoryQuery>
    {
        private ICategoryRepository _categoryRepository;

        public GetCategoryQueryValidator( ICategoryRepository categoryRepository )
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Result> ValidateAsync( GetCategoryQuery data )
        {
            if ( data.CategoryId == default )
            {
                return Result.Fail( new Error( "Category cannot be empty", "Request.CartId" ) );
            }

            bool isCategoryExists = await _categoryRepository.IsCategoryExistsAsync( data.CategoryId );
            if ( !isCategoryExists )
            {
                return Result.Fail( new Error( "Category with this id is not exists", "Request.CartId" ) );
            }

            return Result.Ok();
        }
    }
}