namespace Domain.Entities
{
    public class Product
    {
        public long Id { get; }
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