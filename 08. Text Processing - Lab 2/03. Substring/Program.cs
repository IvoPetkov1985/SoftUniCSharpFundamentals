using System;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            while (secondString.Contains(firstString))
            {
                int start = secondString.IndexOf(firstString);
                secondString = secondString.Remove(start, firstString.Length);
            }

            Console.WriteLine(secondString);
        }
    }
}
