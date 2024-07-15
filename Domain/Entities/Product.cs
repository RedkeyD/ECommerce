namespace Domain.Entities
{
    public class Product
    {
        public Product( string name, string description, decimal price )
        {
            PublicId = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
        }

        public long Id { get; }
        public Guid PublicId { get; }
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public Guid CategoryId { get; }
        public string ImageUrl { get; }
        public Category Category { get; }
        public ICollection<Review> Reviews { get; }


    }
}