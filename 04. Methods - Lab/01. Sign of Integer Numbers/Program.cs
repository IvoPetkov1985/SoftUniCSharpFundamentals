using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber = int.Parse(Console.ReadLine());

            SignPrinter(givenNumber);
        }

        static void SignPrinter(int x)
        {
            if (x > 0)
            {
                Console.WriteLine($"The number {x} is positive.");
            }
            else if (x < 0)
            {
                Console.WriteLine($"The number {x} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {x} is zero.");
            }
        }
    }
}
