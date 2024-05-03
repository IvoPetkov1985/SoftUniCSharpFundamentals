using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInM = int.Parse(Console.ReadLine());
            float distanceInKm = distanceInM / 1000f;
            Console.WriteLine("{0:F2}", distanceInKm);
        }
    }
}
