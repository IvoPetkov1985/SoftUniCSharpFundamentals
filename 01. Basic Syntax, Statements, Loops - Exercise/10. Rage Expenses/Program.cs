using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int headsetsCount = lostGames / 2;
            int miceCount = lostGames / 3;
            int keyboardsCount = miceCount / 2;
            int displaysCount = keyboardsCount / 2;

            decimal sumHeadsets = headsetPrice * headsetsCount;
            decimal sumMice = mousePrice * miceCount;
            decimal sumKeyboards = keyboardPrice * keyboardsCount;
            decimal sumDisplays = displayPrice * displaysCount;

            decimal total = sumHeadsets + sumMice + sumKeyboards + sumDisplays;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
