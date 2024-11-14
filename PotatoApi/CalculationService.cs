using PotatoApi.Entities;

namespace PotatoApi
{
    public interface ICalculationService
    {
        int? Multiplier(int a, int b);
        int? Divide(int a, int b);
        Task<string> CalculateExternalApiAsync();
    }

    public class CalculationService : ICalculationService
    {
        private readonly HttpClient _httpClient;

        public CalculationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> CalculateExternalApiAsync()
        {
            _httpClient.DefaultRequestHeaders.Add("connectionId", "1KTIFTiiNKxbSddf-6CQiQ");
            _httpClient.DefaultRequestHeaders.Add("X-API-KEY", "5B5UYJuCJCREFbQ7coTF0eyc8nC5Svbh5ZWqyUxmvfqEGWq9JsiF4EGAH4LmNiut");

            var result = await _httpClient.GetAsync("https://atikas-space-exploration-api-abbng4buggadcxav.northeurope-01.azurewebsites.net/api/Authors");

            result.EnsureSuccessStatusCode();

            return await result.Content.ReadAsStringAsync();
        }

        public int? Multiplier(int a, int b)
        {
            return a * b;

        }
        public int? Divide(int a, int b)
        {
            return a / b;
        }
    }
}
