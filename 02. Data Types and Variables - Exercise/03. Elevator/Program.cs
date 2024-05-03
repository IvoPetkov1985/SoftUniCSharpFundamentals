using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int personsCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesCount = (int)Math.Ceiling((double)personsCount / elevatorCapacity);
            Console.WriteLine(coursesCount);
        }
    }
}
