using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numsCount; i++)
            {
                int currentNum = i;
                int sumDigits = 0;

                while (currentNum > 0)
                {
                    sumDigits += currentNum % 10;
                    currentNum /= 10;
                }

                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
