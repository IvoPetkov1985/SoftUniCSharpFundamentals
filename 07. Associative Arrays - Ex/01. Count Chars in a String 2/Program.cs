using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            char[] inputAsArray = inputLine.ToCharArray();
            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            for (int i = 0; i < inputAsArray.Length; i++)
            {
                char current = inputAsArray[i];

                if (current == ' ')
                {
                    continue;
                }
                else
                {
                    if (!occurrences.ContainsKey(current))
                    {
                        occurrences[current] = 0;
                    }

                    occurrences[current]++;
                }
            }

            foreach (KeyValuePair<char, int> kvp in occurrences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
