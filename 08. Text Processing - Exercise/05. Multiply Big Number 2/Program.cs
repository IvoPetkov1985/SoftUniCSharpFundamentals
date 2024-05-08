using System;
using System.Text;

namespace _05._Multiply_Big_Number_2
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
                return;
            }

            StringBuilder resultLine = new StringBuilder();

            int remainder = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int productNum = currentDigit * multiplier + remainder;
                resultLine.Insert(0, productNum % 10);
                remainder = productNum / 10;
            }

            if (remainder > 0)
            {
                resultLine.Insert(0, remainder);
            }

            Console.WriteLine(resultLine);
        }
    }
}
