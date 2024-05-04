using System;
using System.Linq;

namespace _05._Top_Integers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                bool isTop = true;
                int currentInt = arrayOfInts[i];

                for (int j = i + 1; j < arrayOfInts.Length; j++)
                {
                    if (arrayOfInts[j] >= currentInt)
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write(currentInt + " ");
                }
            }
        }
    }
}
