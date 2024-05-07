using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string[] words = inputText.Split(" ");
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                int randomIndex = random.Next(0, words.Length);
                string nextWord = words[randomIndex];

                words[randomIndex] = currentWord;
                words[i] = nextWord;
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
