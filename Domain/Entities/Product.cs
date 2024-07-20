namespace Domain.Entities
{
    public class Product
    {
        public long Id { get; private set; }
        public Guid PublicId { get; }
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public long CategoryId { get; }
        public string ImageUrl { get; }
        public Category Category { get; }
        public ICollection<Review> Reviews { get; }
    }
}