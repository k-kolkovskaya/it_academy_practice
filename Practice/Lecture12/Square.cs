﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Square : Base
    {
        public Square(int side) : base(side, "square")
        {
            
        }

        public override double GetSquare()
        {
            return Math.Round((Math.Pow(Side, 2)), 3);
        }
    }
}
