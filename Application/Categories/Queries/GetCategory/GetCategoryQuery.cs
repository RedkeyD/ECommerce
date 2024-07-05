namespace Application.Categories.Queries.GetCategory;

using Domain.Entities;
using MediatR;

public class GetCategoryQuery : IRequest<Category>
{
    public Guid CategoryId { get; }

    public GetCategoryQuery( Guid categoryId)
    {
        CategoryId = categoryId;
    }
}