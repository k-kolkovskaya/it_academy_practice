using System;

namespace Lecture._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHour = DateTime.Now.TimeOfDay.Hours;

            if (currentHour >= 9 & currentHour < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (currentHour>=12 & currentHour<15)
            {
                Console.WriteLine("Good day, guys");
            }
            else if (currentHour >= 15 & currentHour < 22)
            {
                Console.WriteLine("Good evening, guys");
            }
            else
            {
                Console.WriteLine("Good night, guys");
            }
        }
    }
}
