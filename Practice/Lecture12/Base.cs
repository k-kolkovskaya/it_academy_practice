using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class Base
    {
        public int Number;

        public Base (int number)
        {
            Number = number;
        }
        public object[] CreateFigures()
        {
            Round round = new Round(Number);
            Round round1 = new Round(Number);
            Triangle triangle = new Triangle(Number);
            Triangle triangle1 = new Triangle(Number);
            Square square = new Square(Number);

            object[] figureObject =  { round, round1, triangle, triangle1, square };
            
            return figureObject;
        }
    }
}
