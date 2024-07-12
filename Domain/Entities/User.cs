namespace Domain.Entities
{
    public class User
    {
        public long Id { get; }
        public Guid PublicId { get; }
        public ICollection<Order> Orders { get; }
        public Cart Cart { get; }
        public string Username
        {
            get => _username;
            private set
            {
                if ( string.IsNullOrWhiteSpace( value ) )
                {
                    throw new ArgumentNullException( "Username can not be empty string" );
                }

                _username = value;
            }
        }
        private string _username;
        public string Email
        {
            get => _email;
            private set
            {
                if ( string.IsNullOrWhiteSpace( value ) )
                {
                    throw new ArgumentNullException( "email can not be empty string" );
                }

                _email = value;
            }
        }
        private string _email;

        public string PasswordHash
        {
            get => _passwordHash;
            private set
            {
                if ( string.IsNullOrWhiteSpace( value ) )
                {
                    throw new ArgumentNullException( "passwordHash can not be empty string" );
                }

                _passwordHash = value;
            }
        }
        private string _passwordHash;

        public User( string username, string email, string passwordHash )
        {
            PublicId = Guid.NewGuid();
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
        }

        public void SetUsername( string username )
        {
            Username = username;
        }

        public void SetEmail( string email )
        {
            Email = email;
        }

        public void SetPasswordHash( string passwordHash )
        {
            PasswordHash = passwordHash;
        }
    }
}