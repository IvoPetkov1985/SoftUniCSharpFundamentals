using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNum = int.Parse(Console.ReadLine());
            int copyNum = givenNum;
            int sumFactorials = 0;

            while (copyNum > 0)
            {
                int currentDigit = copyNum % 10;
                copyNum /= 10;

                int factorial = 1;
                for (int i = 1; i <= currentDigit; i++)
                {
                    factorial *= i;
                }
                sumFactorials += factorial;
            }

            if (sumFactorials == givenNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
