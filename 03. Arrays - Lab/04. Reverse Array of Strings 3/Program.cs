using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(" ");

            arrayOfStrings = arrayOfStrings.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", arrayOfStrings));
        }
    }
}
