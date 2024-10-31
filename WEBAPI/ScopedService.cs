namespace WEBAPI
{
	public interface IScopedService
	{
		int Increment();
	}

	public class ScopedService : IScopedService
	{
		public ScopedService()
		{

		}


		private int counter;

		public int Increment()
		{
			return counter++;
		}
	}
}
