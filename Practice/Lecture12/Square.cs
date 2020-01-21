using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Square : Base
    {
        private int Side;
        public Square(int side)
        {
            Side = side;
        }

        public double SquareSquare()
        {
            return (Math.Pow(Side, 2));
        }
    }
}
