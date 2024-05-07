using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Random random = new Random();
            string[] words = text.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);

                string currentWord = words[randomIndex];
                string nextWord = words[i];

                words[randomIndex] = nextWord;
                words[i] = currentWord;
            }

            foreach (string item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
