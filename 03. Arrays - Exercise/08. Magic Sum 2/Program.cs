using System;
using System.Linq;

namespace _08._Magic_Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                int currentNum = arrayOfInts[i];

                for (int j = i + 1; j < arrayOfInts.Length; j++)
                {
                    int nextNum = arrayOfInts[j];

                    if (currentNum + nextNum == magicNum)
                    {
                        string result = string.Empty;
                        result += currentNum.ToString() + " ";
                        result += nextNum.ToString();
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
