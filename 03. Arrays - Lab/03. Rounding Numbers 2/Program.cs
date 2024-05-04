using System;
using System.Linq;

namespace _03._Rounding_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfDoubles = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            int[] arrayOfRounded = new int[arrayOfDoubles.Length];

            for (int i = 0; i < arrayOfDoubles.Length; i++)
            {
                double currentDouble = arrayOfDoubles[i];
                arrayOfRounded[i] = (int)Math.Round(currentDouble, MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < arrayOfDoubles.Length; i++)
            {
                Console.WriteLine($"{arrayOfDoubles[i]} => {arrayOfRounded[i]}");
            }
        }
    }
}
