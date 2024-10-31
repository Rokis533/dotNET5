using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		private readonly IScopedService _scopedService;
		private readonly ISingletonService _singletonService;

		public TestController(IScopedService scopedService, ISingletonService singletonService)
		{
			_scopedService = scopedService;
			_singletonService = singletonService;
		}



		[HttpGet("GetScoped")]
		public int GetScoped()
		{
			return _scopedService.Increment();
		}

		[HttpGet("GetSingleton")]
		public int GetSingleton()
		{
			return _singletonService.Increment();
		}

		[HttpGet("GetSingleton2")]
		public int GetSingleton2()
		{
			return _singletonService.Increment();
		}
	}
}
