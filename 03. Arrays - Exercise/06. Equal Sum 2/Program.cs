using System;
using System.Linq;

namespace _06._Equal_Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool areEqual = false;

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    int currentNum = arrayOfInts[j];
                    leftSum += currentNum;
                }

                for (int j = i + 1; j < arrayOfInts.Length; j++)
                {
                    int currentNum = arrayOfInts[j];
                    rightSum += currentNum;
                }

                if (rightSum == leftSum)
                {
                    areEqual = true;
                    Console.WriteLine(i);
                }
            }

            if (!areEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
