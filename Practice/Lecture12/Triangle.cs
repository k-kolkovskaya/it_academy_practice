using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Triangle : Base
    {
        public string Name { get; set; } = "triangle";
        public Triangle(int side) : base(side)
        {
            
        }

        public double GetSquare()
        {
            return ((Math.Sqrt(3) / 4) * Math.Pow(Side, 2));
        }
    }
}
