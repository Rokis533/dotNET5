namespace PotatoApi
{
    public class IamNotHappyException : Exception
    {
        public IamNotHappyException()
        {
        }

        public IamNotHappyException(string? message) : base(message)
        {
        }
    }
}
