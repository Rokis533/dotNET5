namespace WEBAPI
{
	public interface IAppleRepository
	{
		string Get();
	}

	public class AppleRepository : IAppleRepository
	{
		private readonly IAppleStorage _appleStorage;
		public string Get()
		{
			return "Apple";
		}
	}
}
