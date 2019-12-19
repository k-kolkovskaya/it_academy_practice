using System;


namespace Lecture._06
{
    public class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a word");
                string selection = Console.ReadLine();

                int counter = 0;

                for (int i = 0; i < selection.Length; i++)
                {
                    if (selection[i] == 'a')
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);

                Console.ReadLine();
            }
        }
    }
