namespace ProductApplication.Common
{
    public class DatabaseOverPopulatedException : Exception
    {
        public DatabaseOverPopulatedException(string? message) : base(message)
        {
        }
    }
}
