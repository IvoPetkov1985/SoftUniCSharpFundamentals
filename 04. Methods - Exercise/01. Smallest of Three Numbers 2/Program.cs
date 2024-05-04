using System;

namespace _01._Smallest_of_Three_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = SmallestNum(first, second, third);
            Console.WriteLine(result);
        }

        static int SmallestNum(int a, int b, int c)
        {
            int[] arrayOfInts = new int[3] { a, b, c };

            int minValue = int.MaxValue;

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                if (arrayOfInts[i] < minValue)
                {
                    minValue = arrayOfInts[i];
                }
            }

            return minValue;
        }
    }
}
