using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Topic
{
    internal class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public FourSideGeometricFigure(string name, double @base, double height)
        {
            Name = name;
            Base = @base;
            Height = height;
        }

        public double GetArea()
        {
            return Height * Base;
        }
        public override string ToString()
        {
            return $"Figure Name: {Name}, \nBase: {Base}, \nHeight: {Height}, \nArea: {GetArea()}";
        }
    }
}
