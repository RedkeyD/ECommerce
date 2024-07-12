namespace Application.Foundation.Result
{
    public record Warning
    {
        public string Message { get; private init; }
        public string Location { get; private init; }

        public static readonly Warning None = null;

        public Warning( string message, string location )
        {
            Message = message;
            Location = location;
        }
    }
}
