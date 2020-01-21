using System;

namespace Lecture12
{
    class Program
    {
        static void Main(string[] args)
        {
            Base base1 = new Base(12);
            Console.WriteLine(base1.Side);

            for (int i = 0; i < base1.CreateFigures().Length; i++)
            {
                Console.WriteLine(base1.CreateFigures()[i]);
            }
        }
    }
}
