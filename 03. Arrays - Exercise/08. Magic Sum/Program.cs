using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numsArray.Length; i++)
            {
                int firstNum = numsArray[i];

                for (int j = i + 1; j < numsArray.Length; j++)
                {
                    int secondNum = numsArray[j];

                    if (firstNum + secondNum == magicSum)
                    {
                        Console.Write($"{firstNum} {secondNum}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
