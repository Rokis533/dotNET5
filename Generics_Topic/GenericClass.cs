using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Topic
{
    internal class GenericClass<T1, T2>
    {
        private T1? Data;
        private T2? Data2;

        public void Set(T1 t1, T2 t2)
        {
            Data = t1;
            Data2 = t2;
        }
        public T1 GetT1()
        {
            return Data;
        }
        public T2 GetT2()
        {
            return Data2;
        }

    }
}
