using Application.Foundation.Result;
using Application.Shop.Categories.Dtos;

namespace Application.Categories.Queries.GetCategory
{
    public class GetCategoryQueryResult : Result<GetCategoryQueryResult, IReadOnlyList<CategoryDto>>
    {
    }
}