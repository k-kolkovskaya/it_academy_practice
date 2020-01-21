using System;

namespace Lecture12
{
    class Program
    {
        static void Main(string[] args)
        {
            Base base1 = new Base(12);

            for (int i = 0; i < base1.CreateFigures().Length; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
