using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());

            decimal sumNums = 0;

            for (int i = 0; i < numsCount; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                sumNums += currentNum;
            }

            Console.WriteLine(sumNums);
        }
    }
}
