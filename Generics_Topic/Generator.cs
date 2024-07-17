using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Topic
{
    internal class Generator<T>
    {
        private readonly T _value;
        public void Show(T obj)
        {
            Console.WriteLine(obj.ToString());
        }
        public void ShowNice(T obj)
        {
            Console.WriteLine(obj);
        }
    }
    // example of setted T like:\/
    // var generatorVegetable = new Generator<Vegetable>();

    //internal class Generator
    //{
    //    private readonly Vegetable _value;
    //    public void Show(Vegetable obj)
    //    {
    //        Console.WriteLine(obj);
    //    }
    //    public void ShowNice(Vegetable obj)
    //    {
    //        Console.WriteLine(obj);
    //    }
    //}
}
