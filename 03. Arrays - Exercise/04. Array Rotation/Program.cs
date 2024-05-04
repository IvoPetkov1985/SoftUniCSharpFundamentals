using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationsCount % arrayOfInts.Length; i++)
            {
                int firstElement = arrayOfInts[0];

                for (int j = 0; j < arrayOfInts.Length - 1; j++)
                {
                    int nextElement = arrayOfInts[j + 1];
                    arrayOfInts[j] = nextElement;
                }

                arrayOfInts[arrayOfInts.Length - 1] = firstElement;
            }

            Console.WriteLine(String.Join(" ", arrayOfInts));
        }
    }
}
