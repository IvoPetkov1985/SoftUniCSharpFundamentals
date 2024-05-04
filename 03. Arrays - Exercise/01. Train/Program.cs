using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int[] trainArr = new int[wagonsCount];

            for (int i = 0; i < trainArr.Length; i++)
            {
                int passengersInWagon = int.Parse(Console.ReadLine());
                trainArr[i] = passengersInWagon;
            }

            Console.WriteLine(String.Join(" ", trainArr));

            int sum = trainArr.Sum();

            Console.WriteLine(sum);
        }
    }
}
