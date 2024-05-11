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
                string heroDetailsLine = Console.ReadLine();
                string[] tokens = heroDetailsLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                int hp = int.Parse(tokens[1]);
                int mp = int.Parse(tokens[2]);
                Hero hero = new Hero(name, hp, mp);
                party.Add(hero);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] commandDetails = commandLine.Split(" - ");
                string command = commandDetails[0];
                string heroName = commandDetails[1];

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(commandDetails[2]);
                    string spellName = commandDetails[3];

                    Hero currentHero = party.Find(x => x.HeroName == heroName);
                    if (currentHero.MP >= mpNeeded)
                    {
                        currentHero.MP -= mpNeeded;
                        Console.WriteLine($"{currentHero.HeroName} has successfully cast {spellName} and now has {currentHero.MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currentHero.HeroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(commandDetails[2]);
                    string attacker = commandDetails[3];

                    Hero heroToDamage = party.Find(x => x.HeroName == heroName);
                    if (heroToDamage.HP > damage)
                    {
                        heroToDamage.HP -= damage;
                        Console.WriteLine($"{heroToDamage.HeroName} was hit for {damage} HP by {attacker} and now has {heroToDamage.HP} HP left!");
                    }
                    else
                    {
                        party.Remove(heroToDamage);
                        Console.WriteLine($"{heroToDamage.HeroName} has been killed by {attacker}!");
                    }
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(commandDetails[2]);

                    Hero heroToRecharge = party.Find(x => x.HeroName == heroName);
                    int oldmp = heroToRecharge.MP;
                    heroToRecharge.MP += amount;
                    if (heroToRecharge.MP > 200)
                    {
                        heroToRecharge.MP = 200;
                        Console.WriteLine($"{heroToRecharge.HeroName} recharged for {200 - oldmp} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroToRecharge.HeroName} recharged for {amount} MP!");
                    }
                }
                else if (command == "Heal")
                {
                    int healAmount = int.Parse(commandDetails[2]);
                    Hero heroToHeal = party.Find(x => x.HeroName == heroName);
                    int oldhp = heroToHeal.HP;
                    heroToHeal.HP += healAmount;
                    if (heroToHeal.HP > 100)
                    {
                        heroToHeal.HP = 100;
                        Console.WriteLine($"{heroToHeal.HeroName} healed for {100 - oldhp} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroToHeal.HeroName} healed for {healAmount} HP!");
                    }
                }

                commandLine = Console.ReadLine();
            }

            foreach (Hero hero in party)
            {
                Console.WriteLine($"{hero.HeroName}");
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"  MP: {hero.MP}");
            }
        }
    }

    public class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            this.HeroName = name;
            this.HP = hp;
            this.MP = mp;
        }
        public string HeroName { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
