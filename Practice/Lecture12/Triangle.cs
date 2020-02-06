using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Triangle : Base
    {
        public Triangle(int side) : base(side, "triangle")
        {
            
        }

        public override double GetSquare()
        {
            return Math.Round(((Math.Sqrt(3) / 4) * Math.Pow(Side, 2)), 3);
        }
    }
}
