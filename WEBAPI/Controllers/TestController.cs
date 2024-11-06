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
        private readonly ITransientService _transientService;

        public TestController(IScopedService scopedService, ISingletonService singletonService, ITransientService transientService)
        {
            _scopedService = scopedService;
            _singletonService = singletonService;
            _transientService = transientService;
        }



        [HttpGet("GetScoped")]
        public int GetScoped()
        {
            _scopedService.Increment();
            return _scopedService.Increment();
        }

        [HttpGet("GetTransient")]
        public int GetTransient()
        {
            _transientService.Increment();
            return _transientService.Increment();
        }

        [HttpGet("GetSingleton")]
        public int GetSingleton()
        {
            _scopedService.Increment();
            return _singletonService.Increment();
        }
    }
}
