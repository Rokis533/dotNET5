using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Topic
{
    internal class Tomato : Vegetable
    {
        public int Juiceness { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Color: {Color}, Juiciness: {Juiceness}";
        }
    }
}
