using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)
                .ToList();

            foreach (string text in textList)
            {
                Console.WriteLine(text);
            }
        }
    }
}
