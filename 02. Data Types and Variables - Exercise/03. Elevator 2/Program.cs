using System;

namespace _03._Elevator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int result = persons / capacity;

            if (persons % capacity != 0)
            {
                Console.WriteLine(result + 1);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
