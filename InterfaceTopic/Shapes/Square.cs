using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTopic.Shapes
{
    internal class Square : IShape
    {
        public Square(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }


        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return Width * 2 + Height * 2;
        }
    }
}
