using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            for (int i = 1; i <= 4; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    result = currentNum;
                }
                if (i == 2)
                {
                    result += currentNum;
                }
                if (i == 3)
                {
                    result /= currentNum;
                }
                if (i == 4)
                {
                    result *= currentNum;
                }
            }

            Console.WriteLine(result);
        }
    }
}
