using System;

namespace Lecture12
{
    class Program
    {
        static void Main(string[] args)
        {
            Base round1 = new Round(10);
            Base round2 = new Round(2);
            Base triangle = new Triangle(1);
            Base triangle1 = new Triangle(3);
            Base square = new Square(9);

            Console.WriteLine(round1.Name);

            Base[] figureObject = { round1, round2, triangle, triangle1, square };

            foreach (Base item in figureObject)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item.ToString()}. Square is {item.GetSquare()}");
            }
        }
    }
}
