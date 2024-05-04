using System;
using System.Linq;

namespace _05._Sum_Even_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int evenSum = 0;

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];

                if (current % 2 == 0)
                {
                    evenSum += current;
                }
            }

            Console.WriteLine(evenSum);
        }
    }
}
