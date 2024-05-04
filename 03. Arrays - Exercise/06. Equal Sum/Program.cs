using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isFound = false;

            for (int i = 0; i < numsArray.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    int currentLeftNum = numsArray[j];
                    leftSum += currentLeftNum;
                }

                for (int j = i + 1; j < numsArray.Length; j++)
                {
                    int currentRightNum = numsArray[j];
                    rightSum += currentRightNum;
                }

                if (leftSum == rightSum)
                {
                    isFound = true;
                    Console.WriteLine(i);
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
