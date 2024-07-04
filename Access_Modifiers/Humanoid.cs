using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Humanoid : Human
    {
        public void Test2()
        {
            Public = 0;
            //Private = 0; //nepasiekiam
            Protected = 0;
            //Internal = 0;
            ProtectedInternal = 0;
            //PrivateProtected = 0;

        }
    }
}
