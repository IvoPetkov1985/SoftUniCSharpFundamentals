using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            int[] first = new int[counter];
            int[] second = new int[counter];

            for (int i = 0; i < counter; i++)
            {
                int[] currentArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    first[i] = currentArr[0];
                    second[i] = currentArr[1];
                }
                else
                {
                    first[i] = currentArr[1];
                    second[i] = currentArr[0];
                }
            }

            Console.WriteLine(String.Join(" ", first));
            Console.WriteLine(String.Join(" ", second));
        }
    }
}
