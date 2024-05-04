using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (givenArray.Length > 1)
            {
                int length = givenArray.Length - 1;
                int[] condensedArray = new int[length];

                for (int i = 0; i < givenArray.Length - 1; i++)
                {
                    condensedArray[i] = givenArray[i] + givenArray[i + 1];
                }

                givenArray = condensedArray;
            }

            Console.WriteLine(givenArray[0]);
        }
    }
}
