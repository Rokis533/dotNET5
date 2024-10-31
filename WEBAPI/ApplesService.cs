namespace WEBAPI
{
	public interface IApplesService
	{
		string Get();
	}

	public class ApplesService : IApplesService
	{
		private readonly IAppleRepository _appleRepository;

		public ApplesService(IAppleRepository appleRepository)
		{
			_appleRepository = appleRepository;
		}

		public string Get()
		{
			return _appleRepository.Get();
		}
	}
}
