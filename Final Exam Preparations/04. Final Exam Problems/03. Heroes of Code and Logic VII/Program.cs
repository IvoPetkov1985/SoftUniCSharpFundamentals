using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());

            List<Hero> party = new List<Hero>();

            for (int i = 0; i < heroesCount; i++)
            {
                string heroInfo = Console.ReadLine();
                string[] details = heroInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = details[0];
                int hitPoints = int.Parse(details[1]);
                int manaPoints = int.Parse(details[2]);

                Hero hero = new Hero(name, hitPoints, manaPoints);
                party.Add(hero);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] cmdArgs = commandLine.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string heroName = cmdArgs[1];

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    Hero heroToCast = party.Find(x => x.Name == heroName);

                    if (heroToCast.MP >= mpNeeded)
                    {
                        heroToCast.MP -= mpNeeded;
                        Console.WriteLine($"{heroToCast.Name} has successfully cast {spellName} and now has {heroToCast.MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroToCast.Name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    Hero heroToDamage = party.Find(x => x.Name == heroName);

                    heroToDamage.HP -= damage;

                    if (heroToDamage.HP > 0)
                    {
                        Console.WriteLine($"{heroToDamage.Name} was hit for {damage} HP by {attacker} and now has {heroToDamage.HP} HP left!");
                    }
                    else
                    {
                        party.Remove(heroToDamage);
                        Console.WriteLine($"{heroToDamage.Name} has been killed by {attacker}!");
                    }
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    Hero heroToRecharge = party.Find(x => x.Name == heroName);
                    int oldValue = heroToRecharge.MP;
                    heroToRecharge.MP += amount;

                    if (heroToRecharge.MP > 200)
                    {
                        heroToRecharge.MP = 200;
                        Console.WriteLine($"{heroToRecharge.Name} recharged for {200 - oldValue} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroToRecharge.Name} recharged for {amount} MP!");
                    }
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    Hero heroToHeal = party.Find(x => x.Name == heroName);
                    int oldValue = heroToHeal.HP;
                    heroToHeal.HP += amount;

                    if (heroToHeal.HP > 100)
                    {
                        heroToHeal.HP = 100;
                        Console.WriteLine($"{heroToHeal.Name} healed for {100 - oldValue} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroToHeal.Name} healed for {amount} HP!");
                    }
                }

                commandLine = Console.ReadLine();
            }

            foreach (Hero hero in party)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"  MP: {hero.MP}");
            }
        }
    }

    public class Hero
    {
        public Hero(string heroName, int hitPoints, int manaPoints)
        {
            this.Name = heroName;
            this.HP = hitPoints;
            this.MP = manaPoints;
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
