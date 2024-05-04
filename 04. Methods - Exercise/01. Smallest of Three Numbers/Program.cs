using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            PrintSmallestNumber(firstNum, secondNum, thirdNum);
        }

        static void PrintSmallestNumber(int x, int y, int z)
        {
            int minNum = int.MaxValue;

            if (x < minNum)
            {
                minNum = x;
            }
            if (y < minNum)
            {
                minNum = y;
            }
            if (z < minNum)
            {
                minNum = z;
            }

            Console.WriteLine(minNum);
        }
    }
}
