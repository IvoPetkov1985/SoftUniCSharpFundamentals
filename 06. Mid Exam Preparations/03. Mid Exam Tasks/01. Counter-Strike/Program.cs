using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int wonBattles = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End of battle")
                {
                    Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnergy}");
                    break;
                }

                int distance = int.Parse(command);

                if (distance > initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initialEnergy} energy");
                    break;
                }
                else
                {
                    initialEnergy -= distance;
                    wonBattles++;
                }

                if (wonBattles % 3 == 0)
                {
                    initialEnergy += wonBattles;
                }
            }
        }
    }
}
