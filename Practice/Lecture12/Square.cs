using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Square : Base
    {
        public string Name { get; set; } = "square";
        public Square(int side) : base(side)
        {
            
        }

        public double GetSquare()
        {
            return (Math.Pow(Side, 2));
        }
    }
}
