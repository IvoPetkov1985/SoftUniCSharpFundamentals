using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());            

            for (int num = 1; num <= counter; num++)
            {
                bool isTrue = false;
                int currentNum = num;
                int sumDigits = 0;

                while (currentNum > 0)
                {
                    sumDigits += currentNum % 10;
                    currentNum /= 10;
                }

                isTrue = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine("{0} -> {1}", num, isTrue);
            }
        }
    }
}
