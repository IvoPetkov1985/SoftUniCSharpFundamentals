using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = PowerCalculator(num, power);
            Console.WriteLine(result);
        }

        static double PowerCalculator(double a, int p)
        {
            double result = 1;

            for (int i = 1; i <= p; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}
