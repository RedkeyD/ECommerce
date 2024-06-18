namespace Domain.Entities;

public class Review
{
    public Guid Id { get; }
    public Guid ProductId { get; }
    public Guid UserId { get; }
    public int Rating { get; }
    public string Comment { get; }
    public DateTime ReviewDate { get; }
    public Product Product { get; }
    public User User { get; }

    public Review( Guid productId, Guid userId, int rating, string comment )
    {
        if ( userId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( userId )}' cannot be null " );
        }

        if ( productId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( productId )}' cannot be null " );
        }

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
}