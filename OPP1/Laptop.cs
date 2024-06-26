using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OPP1
{
    internal class Laptop(string name, DateTime buildDate, string graphicCard, string cPU, int rAM, bool hasFloppy)
    {
        public string Name { get; set; } = name;
        public DateTime BuildDate { get; set; } = buildDate;
        public string GraphicCard { get; set; } = graphicCard;
        public string CPU { get; set; } = cPU;
        public int RAM { get; set; } = rAM;
        public bool HasFloppy { get; set; } = hasFloppy;

    }
}
