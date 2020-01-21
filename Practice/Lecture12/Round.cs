using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Round : Base
    {
        public string Name { get; set; } = "round";
        public Round(int side) : base(side)
        {
            
        }

        public double GetSquare()
        {
            return ((Math.PI) * Math.Pow(Side, 2));
        }
    }
}
