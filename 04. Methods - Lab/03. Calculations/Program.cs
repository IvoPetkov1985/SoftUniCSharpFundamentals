using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (calculation)
            {
                case "add": Add(firstNumber, secondNumber); break;
                case "subtract": Subtract(firstNumber, secondNumber); break;
                case "multiply": Multiply(firstNumber, secondNumber); break;
                case "divide": Divide(firstNumber, secondNumber); break;
            }
        }

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
