using System;
using System.Linq;

namespace _05._Sum_Even_Numbers_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInts = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .Sum();
            Console.WriteLine(inputInts);
        }
    }
}
