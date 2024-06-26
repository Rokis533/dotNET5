using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP1
{
    internal class Car
    {

        public Car(string name) 
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public List<Wheel> Wheels { get; set; }

    }
}
