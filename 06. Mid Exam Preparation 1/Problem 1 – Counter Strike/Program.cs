using System;

namespace Problem_1___Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int battleCounter = 0;

            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (distance > initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battleCounter} won battles and {initialEnergy} energy");
                    break;
                }
                else
                {
                    initialEnergy -= distance;
                    battleCounter++;
                }

                if (battleCounter % 3 == 0)
                {
                    initialEnergy += battleCounter;
                }

                input = Console.ReadLine();
            }

            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {battleCounter}. Energy left: {initialEnergy}");
            }
        }
    }
}
