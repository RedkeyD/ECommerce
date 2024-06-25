namespace Domain.Entities;

public class Review
{
    public Guid Id { get; private init; }
    public Guid ProductId { get; private set; }
    public Guid UserId { get; private set; }
    public int Rating { get; private set; }
    public string Comment { get; private set; }
    public DateTime ReviewDate { get; private set; }
    public Product Product { get; private set; }
    public User User { get; private set; }

    public Review( Guid productId, Guid userId, int rating, string comment)
    {
        if ( rating < 1 || rating > 5 )
        {
            throw new ArgumentException( $"'{nameof( rating )}' must be between 1 and 5.", nameof( rating ) );
        }

        if ( string.IsNullOrWhiteSpace( comment ) )
        {
            throw new ArgumentException( $"'{nameof( comment )}' cannot be null or empty.", nameof( comment ) );
        }

        Id = Guid.NewGuid();
        ProductId = productId;
        UserId = userId;
        Rating = rating;
        Comment = comment;
        ReviewDate = DateTime.Now;
    }

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
        if ( string.IsNullOrWhiteSpace( comment ) )
        {
            throw new ArgumentException( $"'{nameof( comment )}' cannot be null or empty.", nameof( comment ) );
        }

        Comment = comment;
    }
}
