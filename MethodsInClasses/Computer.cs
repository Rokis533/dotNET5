using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MethodsInClasses
{
    internal class Computer
    {

        public string Name { get; set; }
        public DateTime BuildDate { get; set; }
        public string GraphicCard { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public bool HasFloppy { get; set; }

        public List<App> Apps { get; set; }


        public void PrintApps()
        {
            foreach (var app in Apps)
            {
                Console.WriteLine($"Name: {app.Name}, Size: {app.Size}");
            }
        }
        public void PrintApps(int sizeLimit)
        {
            foreach (var app in Apps)
            {
                if (app.Size < sizeLimit)
                {
                    Console.WriteLine($"Name: {app.Name}, Size: {app.Size}");
                }
            }
        }

        public string IsEnoughRAM()
        {

            switch (RAM)
            {
                case < 8:
                    return "Not Enough";
                case < 16:
                    return "Enough";
                case >= 16:
                    return "A lot";
            }

        }

        public void PrintInfo()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Build Date: {BuildDate}");
            Console.WriteLine(Name);
            Console.WriteLine(CPU);
            Console.WriteLine(GraphicCard);
            Console.WriteLine(RAM);
            Console.WriteLine(HasFloppy);
            Console.WriteLine("-------------------------------");
        }




        public override string ToString()
        {
            return $"Build Date: {BuildDate}, Name: {Name}";
        }

    }
}
