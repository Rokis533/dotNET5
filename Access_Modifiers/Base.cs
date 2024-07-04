using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Base
    {
        public virtual void Print()
        {
            Console.WriteLine();
        }
        public virtual void Print2()
        {
            Console.WriteLine();
        }
    }
    internal class Mid : Base
    {
        public sealed override void Print()
        {
            Console.WriteLine();
        }
        public override void Print2()
        {
            Console.WriteLine();
        }
    }
    //internal class Low : Mid
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine();
    //    }
    //    public override void Print2()
    //    {
    //        Console.WriteLine();
    //    }
    //}
}
