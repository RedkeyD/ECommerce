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
            if ( string.IsNullOrWhiteSpace( name ) )
            {
                throw new ArgumentNullException( "name can not be empty string" );
            }

            if ( name.Length > 50 )
            {
                throw new ArgumentException( "name can only have 50 characters" );
            }

            if ( string.IsNullOrWhiteSpace( description ) )
            {
                throw new ArgumentNullException( "name can not be empty string" );
            }

            if ( description.Length > 1500 )
            {
                throw new ArgumentException( "name can only have 50 characters" );
            }

            Name = name;
            Description = description;
            PublicId = Guid.NewGuid();
        }
    }
}