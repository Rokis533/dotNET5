using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace PotatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _calculatorService;

        public CalculationController(ICalculationService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet]
        public ActionResult Calculate(int a, int b)
        {
            var multiplication = _calculatorService.Multiplier(a, b);  // -999

            var division = _calculatorService.Divide(a, b); // 777

            if (multiplication < 0)
            {
                return BadRequest("Cannot multiply by negative");
            }
            if (division < 0)
            {
                return BadRequest("Cannot division by negative");
            }



            return Ok(multiplication + division);
        }
    }
}
