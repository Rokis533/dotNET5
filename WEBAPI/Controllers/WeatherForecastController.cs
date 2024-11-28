using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly HttpClient _httpClient;


        public WeatherForecastController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("Async")]
        public async Task<IActionResult> GetAsync()
        {
            var result1 = _httpClient.GetAsync("https://localhost:7053/api/Potatoes");
            var result2 = _httpClient.GetAsync("https://localhost:7053/api/Potatoes");
            var result3 = _httpClient.GetAsync("https://localhost:7053/api/Potatoes");

            await Task.WhenAll(result1, result2, result3);

            return Ok();
        }

        [HttpGet("Sync")]
        public IActionResult GetSync()
        {
            var result = _httpClient.GetAsync("https://localhost:7053/api/Potatoes").Result;
            return Ok(result.Content);
        }


        // localhost:5555/WeatherForecast/
    }
}
