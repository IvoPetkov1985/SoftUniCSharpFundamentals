using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            double resultCalculation = Calculator(firstNumber, oper, secondNumber);
            Console.WriteLine(resultCalculation);
        }

        static double Calculator(int x, string op, int y)
        {
            double result = 0.0;

            switch (op)
            {
                case "+": result = x + y; break;
                case "-": result = x - y; break;
                case "*": result = x * y; break;
                case "/": result = x / y; break;
            }

            return result;
        }
    }
}
