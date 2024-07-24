using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTopic.Payments
{
    internal class Visa : IPayment
    {

        public bool MakePayment(decimal money)
        {
            Console.WriteLine($"payment made via Visa: {money}");
            return true;
        }

        public decimal SeeBalance(decimal money)
        {
            return money;
        }
    }
}
