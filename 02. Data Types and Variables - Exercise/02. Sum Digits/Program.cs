using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNum = int.Parse(Console.ReadLine());
            int sumDigits = 0;

            while (givenNum > 0)
            {
                int currentDigit = givenNum % 10;
                sumDigits += currentDigit;
                givenNum /= 10;
            }

            Console.WriteLine(sumDigits);
        }
    }
}
