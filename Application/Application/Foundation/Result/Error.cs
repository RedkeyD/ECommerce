namespace Application.Foundation.Result
{
    public record Error
    {
        public string Message { get; private init; }
        public string Location { get; private init; }

        public static readonly Error None = null;

        public Error( string message, string location )
        {
            Message = message;
            Location = location;
        }
    }
}