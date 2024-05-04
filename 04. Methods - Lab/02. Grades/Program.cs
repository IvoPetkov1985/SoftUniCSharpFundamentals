using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            GradePrinter(grade);
        }

        static void GradePrinter(double x)
        {
            if (x >= 2.00 && x <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (x >= 3.00 && x <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (x >= 3.50 && x <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (x >= 4.50 && x <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (x >= 5.50 && x <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
