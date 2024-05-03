using System;

namespace _09._Padawan_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountMoney = decimal.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            decimal singleSaberPrice = decimal.Parse(Console.ReadLine());
            decimal singleRobePrice = decimal.Parse(Console.ReadLine());
            decimal singleBeltPrice = decimal.Parse(Console.ReadLine());

            decimal sumSabers = singleSaberPrice * Math.Ceiling(countOfStudents + countOfStudents * 0.1m);
            decimal sumRobes = singleRobePrice * countOfStudents;
            int freeBelts = countOfStudents / 6;
            decimal sumBelts = singleBeltPrice * (countOfStudents - freeBelts);
            decimal neededSum = sumSabers + sumRobes + sumBelts;

            if (amountMoney >= neededSum)
            {
                Console.WriteLine("The money is enough - it would cost {0:F2}lv.", neededSum);
            }
            else
            {
                Console.WriteLine("John will need {0:F2}lv more.", neededSum - amountMoney);
            }
        }
    }
}
