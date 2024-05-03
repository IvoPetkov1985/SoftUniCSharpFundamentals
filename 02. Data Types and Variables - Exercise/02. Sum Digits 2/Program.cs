using System;

namespace _02._Sum_Digits_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string integerAsText = num.ToString();

            int sumDigits = 0;

            for (int i = 0; i < integerAsText.Length; i++)
            {
                int currentDigit = int.Parse(integerAsText[i].ToString());
                sumDigits += currentDigit;
            }

            Console.WriteLine(sumDigits);
        }
    }
}
