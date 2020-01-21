using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Round : Base
    {
        private int Side;
        public Round(int side)
        {
            Side = side;
        }

        public double RoundSquare()
        {
            return ((Math.PI) * Math.Pow(Side, 2));
        }
    }
}
