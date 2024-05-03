using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            int totalQuantity = 0;
            int tankCapacity = 255;

            for (int i = 1; i <= linesCount; i++)
            {
                int litersWater = int.Parse(Console.ReadLine());

                if (litersWater > tankCapacity - totalQuantity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalQuantity += litersWater;
                }
            }

            Console.WriteLine(totalQuantity);
        }
    }
}
