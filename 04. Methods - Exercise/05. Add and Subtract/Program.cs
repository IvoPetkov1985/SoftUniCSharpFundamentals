using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = Calculate(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);
        }

        static int Calculate(int a, int b, int c)
        {
            int sumOfFirstAndSecond = a + b;
            return sumOfFirstAndSecond - c;
        }
    }
}
