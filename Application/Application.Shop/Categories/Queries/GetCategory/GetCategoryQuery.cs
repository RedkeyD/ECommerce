using Application.Abstractions.Messaging;

namespace Application.Categories.Queries.GetCategory
{
    public class GetCategoryQuery : IQuery<GetCategoryQueryResult>
    {
        public Guid CategoryId { get; set; }
    }
}