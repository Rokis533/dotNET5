namespace WEBAPI
{
	public interface IAppleStorage
	{
		List<string> Get();
	}

	public class AppleStorage : IAppleStorage
	{
		private readonly List<string> list = new List<string> { "Alyvinis", "Saldinis", "Rudeninis" };

		public List<string> Get()
		{
			return list;
		}

	}
}
