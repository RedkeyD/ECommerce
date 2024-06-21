namespace Domain.Entities;

public class Review
{
    public Guid ReviewId { get; private init; }
    public Guid ProductId { get; private set; }
    public Guid UserId { get; private set; }
    public int Rating { get; private set; }
    public string Comment { get; private set; }
    public DateTime ReviewDate { get; private set; }
    public Product Product { get; private set; }
    public User User { get; private set; }

    public Review( Guid productId, Guid userId, int rating, string comment, DateTime reviewDate )
    {
        if ( rating < 1 || rating > 5 )
        {
            throw new ArgumentException( $"'{nameof( rating )}' must be between 1 and 5.", nameof( rating ) );
        }

        if ( string.IsNullOrEmpty( comment ) )
        {
            throw new ArgumentException( $"'{nameof( comment )}' cannot be null or empty.", nameof( comment ) );
        }

        if ( reviewDate == default )
        {
            throw new ArgumentException( $"'{nameof( reviewDate )}' cannot be default.", nameof( reviewDate ) );
        }

        ReviewId = Guid.NewGuid();
        ProductId = productId;
        UserId = userId;
        Rating = rating;
        Comment = comment;
        ReviewDate = reviewDate;
    }

    private Review() { }

    public void SetRating( int rating )
    {
        if ( rating < 1 || rating > 5 )
        {
            throw new ArgumentException( $"'{nameof( rating )}' must be between 1 and 5.", nameof( rating ) );
        }

        Rating = rating;
    }

    public void SetComment( string comment )
    {
        if ( string.IsNullOrEmpty( comment ) )
        {
            throw new ArgumentException( $"'{nameof( comment )}' cannot be null or empty.", nameof( comment ) );
        }

        Comment = comment;
    }
}
