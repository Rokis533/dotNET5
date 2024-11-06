namespace WEBAPI
{
    public interface ITransientService
    {
        int Increment();
    }

    public class TransientService : ITransientService
    {
        public TransientService()
        {

        }


        private int counter = 1;

        public int Increment()
        {
            return counter++;
        }
    }
}
