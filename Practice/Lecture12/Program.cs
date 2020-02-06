using System;

namespace Lecture12
{
    class Program
    {
        static void Main(string[] args)
        {
            Round round1 = new Round(10);
            Round round2 = new Round(2);
            Triangle triangle = new Triangle(1);
            Triangle triangle1 = new Triangle(3);
            Square square = new Square(9);

            Base[] figureObject = { round1, round2, triangle, triangle1, square };

            foreach (Base item in figureObject)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item.ToString()}. Square is {item.GetSquare()}");
            }
        }
    }
}
