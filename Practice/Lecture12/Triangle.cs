using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Triangle : Base
    {
        private int Side;
        public Triangle(int side)
        {
            Side = side;
        }

        public double TriangleSquare ()
        {
            return ((Math.Sqrt(3) / 4) * Math.Pow(Side, 2));
        }
    }
}
