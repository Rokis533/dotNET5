using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OPP1
{
    internal class Computer
    {
        public Computer()
        {
            BuildDate = DateTime.Now;
        }
        public Computer(string name) : this()
        {
            Name = name;
        }

        public Computer(string graphicCard, string cpu, int ram, bool hasFloppy, string name = "No name") : this(name)
        {
            //Name = name;
            GraphicCard = graphicCard;
            CPU = cpu;
            HasFloppy = hasFloppy;
            RAM = ram;
        }

        public string Name { get; set; }
        public DateTime BuildDate { get; set; }
        public string GraphicCard { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public bool HasFloppy { get; set; }


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
