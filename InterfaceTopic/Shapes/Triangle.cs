using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTopic.Shapes
{
    internal class Triangle : IShape
    {
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return Width * Height / 2;
        }

        public double GetPerimeter()
        {
            return Width + Height + Math.Sqrt(Height * Height + Width * Width);
        }
    }
}
