using System;

namespace _01._Randomize_Words_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(" ");

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);
                string currentWord = words[randomIndex];
                string nextWord = words[i];

                words[i] = currentWord;
                words[randomIndex] = nextWord;                
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
