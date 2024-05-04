using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < numsArray.Length; i++)
            {
                int num = numsArray[i];
                bool isTop = true;

                for (int j = i + 1; j < numsArray.Length; j++)
                {
                    int currentNum = numsArray[j];

                    if (currentNum >= num)
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
