using System;

namespace _07._Water_Overflow_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte linesCount = byte.Parse(Console.ReadLine());

            short litersPoured = 0;
            short tankCapacity = 255;

            for (byte i = 1; i <= linesCount; i++)
            {
                short litersWater = short.Parse(Console.ReadLine());

                if (litersWater <= tankCapacity - litersPoured)
                {
                    litersPoured += litersWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(litersPoured);
        }
    }
}
