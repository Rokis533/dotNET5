using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplesController : ControllerBase
    {
        private readonly IApplesService _applesService;
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;

        public ApplesController(IApplesService applesService, ITransientService transientService, IScopedService scopedService)
        {
            _applesService = applesService;
            _transientService = transientService;
            _scopedService = scopedService;
        }

        [HttpGet]
        public object Get()
        {

            var apple = _applesService.Get();

            return new
            {
                transient = _transientService.Increment(),
                scoped = _scopedService.Increment(),
            };
        }
    }
}
