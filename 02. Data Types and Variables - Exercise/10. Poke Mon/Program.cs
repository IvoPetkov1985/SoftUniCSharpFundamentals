using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int n = pokePowerN;
            int pokesCounter = 0;

            while (true)
            {
                if (n < distanceM)
                {
                    Console.WriteLine(n);
                    Console.WriteLine(pokesCounter);
                    break;
                }

                n -= distanceM;
                pokesCounter++;

                if (n == (double)(pokePowerN / 2))
                {
                    if (exhaustionFactorY != 0)
                    {
                        n /= exhaustionFactorY;
                    }
                }
            }
        }
    }
}
