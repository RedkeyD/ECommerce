namespace Domain.Entities;

public class Product
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; }
    public Guid CategoryId { get; }
    public string ImageUrl { get; }
    public Category Category { get; }
    public ICollection<Review> Reviews { get; }
}