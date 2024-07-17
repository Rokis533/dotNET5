using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Topic
{
    internal class MyClass<T1, T2>
    {
        private T1 value1;
        private T2 value2;

        public MyClass(T1 val1, T2 val2)
        {
            value1 = val1;
            value2 = val2;
        }
        public void SetValue1(T1 val1)
        {
            value1 = val1;
        }
        public void SetValue2(T2 val2)
        {
            value2 = val2;
        }
        public T1 GetValue1()
        {
            return value1;
        }
        public T2 GetValue2()
        {
            return value2;
        }

    }
}
