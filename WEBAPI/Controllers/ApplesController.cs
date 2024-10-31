using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ApplesController : ControllerBase
	{
		private readonly IApplesService _applesService;

		public ApplesController(IApplesService applesService)
		{
			_applesService = applesService;
		}

		[HttpGet]
		public string Get()
		{

			var apple = _applesService.Get();

			return apple;
		}
	}
}
