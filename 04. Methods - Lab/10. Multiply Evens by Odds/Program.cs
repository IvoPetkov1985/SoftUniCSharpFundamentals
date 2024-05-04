using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int absoluteNumber = Math.Abs(inputNumber);

            int sumEvens = AllEvenDigitsSum(absoluteNumber);
            int sumOdds = AllOddDigitsSum(absoluteNumber);
            int result = GetMultiple(sumOdds, sumEvens);
            Console.WriteLine(result);
        }

        static int GetMultiple(int x, int y)
        {
            return x * y;
        }

        static int AllEvenDigitsSum(int num)
        {
            int evenSum = 0;

            while (num > 0)
            {
                int currentDigit = num % 10;

                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }

                num /= 10;
            }

            return evenSum;
        }

        static int AllOddDigitsSum(int num)
        {
            int oddSum = 0;

            while (num > 0)
            {
                int currentDigit = num % 10;

                if (currentDigit % 2 != 0)
                {
                    oddSum += currentDigit;
                }

                num /= 10;
            }

            return oddSum;
        }
    }
}
