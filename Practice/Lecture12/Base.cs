using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Base
    {
        public int Side { get; set; }

        public Base (int side)
        {
            Side = side;
        }
        public virtual object[] CreateFigures()
        {
            Round round = new Round(Side);
            Round round1 = new Round(Side);
            Triangle triangle = new Triangle(Side);
            Triangle triangle1 = new Triangle(Side);
            Square square = new Square(Side);

            object[] figureObject =  { round, round1, triangle, triangle1, square };
            
            return figureObject;
        }
    }
}
