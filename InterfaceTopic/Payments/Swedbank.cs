using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTopic.Payments
{
    internal class Swedbank : IPayment
    {

        public bool MakePayment(decimal money)
        {
            Console.WriteLine($"payment made via Swedbank: {money}");
            return true;
        }
    }
}
