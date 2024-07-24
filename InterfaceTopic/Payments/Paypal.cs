using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTopic.Payments
{
    internal class Paypal : IPayment
    {
        public bool MakePayment(decimal money)
        {
            Console.WriteLine($"payment made via paypal: {money}");
            return true;
        }
    }
}
