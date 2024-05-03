using System;

namespace _10._Poke_Mon_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonPowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int factorY = int.Parse(Console.ReadLine());

            int currentPower = pokemonPowerN;
            int pokesCounter = 0;

            while (currentPower >= distanceM)
            {
                currentPower -= distanceM;
                pokesCounter++;

                if (currentPower == (double)pokemonPowerN / 2)
                {
                    if (factorY != 0)
                    {
                        currentPower /= factorY;
                    }
                }
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(pokesCounter);
        }
    }
}
