using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string element = string.Empty;
            int counter = 1;
            int maxCounter = 0;

            for (int i = 0; i < arrayOfInts.Length - 1; i++)
            {
                int currentElement = arrayOfInts[i];

                if (currentElement == arrayOfInts[i + 1])
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
                    element = currentElement.ToString();
                }
            }

            string result = string.Empty;

            for (int i = 1; i <= maxCounter; i++)
            {
                result += element + " ";
            }

            Console.WriteLine(result.Trim());
        }
    }
}
