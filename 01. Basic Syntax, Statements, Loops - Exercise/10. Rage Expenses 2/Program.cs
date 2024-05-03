using System;

namespace _10._Rage_Expenses_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double monitorPrice = double.Parse(Console.ReadLine());

            int headsets = 0;
            int mice = 0;
            int keyboards = 0;
            int monitors = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsets++;
                }
                if (i % 3 == 0)
                {
                    mice++;
                }
                if (i % 6 == 0)
                {
                    keyboards++;
                }
                if (i % 12 == 0)
                {
                    monitors++;
                }
            }

            double sum = headsets * headsetPrice + mice * mousePrice + keyboards * keyboardPrice + monitors * monitorPrice;

            Console.WriteLine($"Rage expenses: {sum:F2} lv.");
        }
    }
}
