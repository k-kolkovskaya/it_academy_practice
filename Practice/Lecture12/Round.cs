using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Round : Base
    {
        public Round(int side) : base(side, "round")
        {
            
        }

        public override double GetSquare()
        {
            return Math.Round(((Math.PI) * Math.Pow(Side, 2)), 3);
        }
    }
}
