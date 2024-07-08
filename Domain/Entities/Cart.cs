namespace Domain.Entities;

public class Cart
{
    public Guid Id { get; }
    public Guid UserId { get; }
    public DateTime CreatedDate { get; }
    public ICollection<CartItem> CartItems { get; private set; }
    public User User { get; }

    public Cart( Guid userId )
    {
        if ( userId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( userId )}' cannot be null " );
        }

        Id = Guid.NewGuid();
        UserId = userId;
        CreatedDate = DateTime.Now;
    }

    public void AddProduct( Product product, int quantity )
    {
        CartItem existingItem = CartItems.FirstOrDefault( ci => ci.ProductId == product.Id );

        if ( existingItem != null )
        {
            existingItem.SetQuantity( quantity );
        }
        else
        {
            CartItem cartItem = new CartItem( Id, product.Id, quantity );
            CartItems.Add( cartItem );
        }
    }

    public void RemoveProduct( Guid productId )
    {
        CartItem item = CartItems.FirstOrDefault( ci => ci.ProductId == productId );

        if ( item != null )
        {
            CartItems.Remove( item );
        }
    }

    public void UpdateProductQuantity( Guid productId, int quantity )
    {
        CartItem item = CartItems.FirstOrDefault( ci => ci.ProductId == productId );

        if ( item != null )
        {
            item.SetQuantity( quantity );
        }
    }
}