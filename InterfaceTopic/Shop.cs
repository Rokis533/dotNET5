using InterfaceTopic.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTopic
{
    internal class Shop
    {
        public void Buying(decimal amount, IPayment payment)
        {
            payment.MakePayment(amount);
        }
    }
}
