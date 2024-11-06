namespace WEBAPI
{
	public interface IApplesService
	{
		string Get();
	}

	public class ApplesService : IApplesService
	{
		private readonly IAppleRepository _appleRepository;
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;

        public ApplesService(IAppleRepository appleRepository, ITransientService transientService, IScopedService scopedService)
        {
            _appleRepository = appleRepository;
            _transientService = transientService;
            _scopedService = scopedService;
        }

        public string Get()
		{
            _transientService.Increment();
            _scopedService.Increment();
			return _appleRepository.Get();
		}
	}
}
