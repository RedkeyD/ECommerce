namespace Domain.Entities
{
    public class Category
    {
        public long Id { get; }
        public Guid PublicId { get; }
        public string Name { get; }
        public string Description { get; }
        public ICollection<Product> Products { get; }

        public Category( string name, string description )
        {
            Name = name;
            Description = description;
            PublicId = Guid.NewGuid();
        }
    }
}