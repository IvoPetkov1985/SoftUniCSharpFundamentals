using System;

namespace _01._Day_of_Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(daysOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
