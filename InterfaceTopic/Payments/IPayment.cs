﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTopic.Payments
{
    internal interface IPayment
    {
        public bool MakePayment(decimal money);
    }
}
