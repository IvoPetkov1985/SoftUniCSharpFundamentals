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

            Console.WriteLine(StringNumMultiplier(bigNumber, multiplier));
        }

        static string StringNumMultiplier(string bigNum, int multiplier)
        {
            if (bigNum == "0" || multiplier == 0)
            {
                return "0";
            }

            StringBuilder resultLine = new StringBuilder();

            int remainder = 0;

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNum[i].ToString());
                int product = digit * multiplier + remainder;
                resultLine.Insert(0, product % 10);
                remainder = product / 10;
            }

            if (remainder > 0)
            {
                resultLine.Insert(0, remainder);
            }

            return resultLine.ToString();
        }
    }
}
