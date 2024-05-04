using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double firstFactorial = FactorialCalculator(firstNum);
            double secondFactorial = FactorialCalculator(secondNum);
            double result = firstFactorial / secondFactorial;
            Console.WriteLine("{0:F2}", result);
        }

        static double FactorialCalculator(int num)
        {
            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
