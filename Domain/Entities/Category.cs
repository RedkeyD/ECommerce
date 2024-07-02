namespace Domain.Entities;

public class Category
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public ICollection<Product> Products { get; }
}