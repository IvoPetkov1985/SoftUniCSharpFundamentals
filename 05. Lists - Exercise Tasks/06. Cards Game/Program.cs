using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayersCards = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayersCards = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (firstPlayersCards[0] > secondPlayersCards[0])
                {
                    firstPlayersCards.Add(firstPlayersCards[0]);
                    firstPlayersCards.Add(secondPlayersCards[0]);
                }
                else if (firstPlayersCards[0] < secondPlayersCards[0])
                {
                    secondPlayersCards.Add(secondPlayersCards[0]);
                    secondPlayersCards.Add(firstPlayersCards[0]);
                }

                firstPlayersCards.RemoveAt(0);
                secondPlayersCards.RemoveAt(0);

                if (firstPlayersCards.Count == 0)
                {
                    int sum = secondPlayersCards.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPlayersCards.Count == 0)
                {
                    int sum = firstPlayersCards.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
