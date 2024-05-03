using System;

namespace _09._Padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabersSum = lightsaberPrice * Math.Ceiling(studentsCount + studentsCount * 0.1);
            double robesSum = robePrice * studentsCount;
            int freeBelts = studentsCount / 6;
            double beltsSum = beltPrice * (studentsCount - freeBelts);

            double totalSum = lightsabersSum + robesSum + beltsSum;

            if (amountOfMoney >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - amountOfMoney:f2}lv more.");
            }
        }
    }
}
