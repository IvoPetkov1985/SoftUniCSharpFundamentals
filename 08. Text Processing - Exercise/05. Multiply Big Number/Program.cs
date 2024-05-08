using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (bigNumber == "0" || multiplier == 0)
            {
                Console.WriteLine("0");
                Environment.Exit(0);
            }

            int remainder = 0;

            StringBuilder result = new StringBuilder();

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int product = currentDigit * multiplier + remainder;
                result.Insert(0, product % 10);
                remainder = product / 10;
            }

            if (remainder > 0)
            {
                result.Insert(0, remainder);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
