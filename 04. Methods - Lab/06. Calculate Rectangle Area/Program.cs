using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = AreaCalculator(width, height);
            Console.WriteLine(area);
        }

        static double AreaCalculator(double a, double b)
        {
            return a * b;
        }
    }
}
