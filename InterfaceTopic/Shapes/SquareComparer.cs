using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTopic.Shapes
{
    internal class SquareComparer : IComparer<Square>
    {
        public int Compare(Square? x, Square? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null)
            {
                return 1;
            }
            if (y == null)
            {
                return -1;
            }

            if (x.GetArea() > y.GetArea())
            {
                return -1;
            }
            if (x.GetArea() < y.GetArea())
            {
                return 1;
            }

            return 0;


        }
    }
}
