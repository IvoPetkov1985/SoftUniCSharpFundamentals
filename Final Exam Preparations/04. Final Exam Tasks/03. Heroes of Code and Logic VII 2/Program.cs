using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroesCollection = new Dictionary<string, int[]>();

            for (int i = 0; i < heroesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] heroDetails = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroDetails.First();
                int heroHP = int.Parse(heroDetails[1]);
                int heroMP = int.Parse(heroDetails.Last());

                if (!heroesCollection.ContainsKey(heroName))
                {
                    heroesCollection.Add(heroName, new int[2]);
                    heroesCollection[heroName][0] = heroHP;
                    heroesCollection[heroName][1] = heroMP;
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] cmdArgs = commandLine.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs.First();
                string name = cmdArgs[1];

                switch (command)
                {
                    case "CastSpell":
                        int neededMP = int.Parse(cmdArgs[2]);
                        string spellName = cmdArgs.Last();

                        if (heroesCollection[name][1] >= neededMP)
                        {
                            heroesCollection[name][1] -= neededMP;
                            Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroesCollection[name][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(cmdArgs[2]);
                        string attacker = cmdArgs.Last();

                        heroesCollection[name][0] -= damage;

                        if (heroesCollection[name][0] > 0)
                        {
                            Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroesCollection[name][0]} HP left!");
                        }
                        else
                        {
                            heroesCollection.Remove(name);
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                        }
                        break;

                    case "Recharge":
                        int amount = int.Parse(cmdArgs.Last());
                        int oldAmount = heroesCollection[name][1];

                        heroesCollection[name][1] += amount;

                        if (heroesCollection[name][1] > 200)
                        {
                            heroesCollection[name][1] = 200;
                            Console.WriteLine($"{name} recharged for {200 - oldAmount} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} recharged for {amount} MP!");
                        }
                        break;

                    case "Heal":
                        int healAmount = int.Parse(cmdArgs.Last());
                        int oldHealAmount = heroesCollection[name][0];

                        heroesCollection[name][0] += healAmount;

                        if (heroesCollection[name][0] > 100)
                        {
                            heroesCollection[name][0] = 100;
                            Console.WriteLine($"{name} healed for {100 - oldHealAmount} HP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} healed for {healAmount} HP!");
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int[]> hero in heroesCollection)
            {
                string name = hero.Key;
                int currentHP = hero.Value[0];
                int currentMP = hero.Value[1];

                Console.WriteLine(name);
                Console.WriteLine($"  HP: {currentHP}");
                Console.WriteLine($"  MP: {currentMP}");
            }
        }
    }
}
