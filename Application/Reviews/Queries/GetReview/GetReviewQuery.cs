namespace Application.Reviews.Queries.GetReview;

using Domain.Entities;
using MediatR;

public class GetReviewQuery : IRequest<Review>
{
    public Guid ReviewId { get; }

    public GetReviewQuery(Guid reviewId)
    {
        ReviewId = reviewId;
    }
}