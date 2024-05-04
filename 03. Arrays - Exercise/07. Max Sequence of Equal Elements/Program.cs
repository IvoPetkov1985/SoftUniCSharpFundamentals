using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int counter = 1;
            int maxCounter = 0;
            int element = 0;

            for (int i = 0; i < numsArray.Length - 1; i++)
            {
                if (numsArray[i] == numsArray[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    element = numsArray[i];
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
