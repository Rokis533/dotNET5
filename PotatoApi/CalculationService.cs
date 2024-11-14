using PotatoApi.Entities;

namespace PotatoApi
{
    public interface ICalculationService
    {
        int? Multiplier(int a, int b);
        int? Divide(int a, int b);
    }

    public class CalculationService : ICalculationService
    {

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
