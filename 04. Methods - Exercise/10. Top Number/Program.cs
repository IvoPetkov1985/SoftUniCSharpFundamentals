using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            SpecialNum(inputNum);
        }

        static void SpecialNum(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                bool isDivisibleBy8 = false;
                bool hasOddDigit = false;

                int sumDigits = 0;

                while (currentNum > 0)
                {
                    int currentDigit = currentNum % 10;
                    sumDigits += currentDigit;
                    currentNum /= 10;
                }

                if (sumDigits % 8 == 0)
                {
                    isDivisibleBy8 = true;
                }

                int checkedNum = i;

                while (checkedNum > 0)
                {
                    int currentDigit = checkedNum % 10;

                    if (currentDigit % 2 == 1)
                    {
                        hasOddDigit = true;
                        break;
                    }

                    checkedNum /= 10;
                }

                if (isDivisibleBy8 && hasOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
