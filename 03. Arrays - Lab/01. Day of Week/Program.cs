using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            if (input > 7 || input < 1)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[input - 1]);
            }
        }
    }
}
