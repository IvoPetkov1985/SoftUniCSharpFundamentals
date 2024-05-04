using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            CharactersPrint(text);
        }

        static void CharactersPrint(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Length % 2 == 0)
                {
                    if (i == word.Length / 2)
                    {
                        Console.Write($"{word[i - 1]}{word[i]}");
                    }
                }
                else
                {
                    if (i == word.Length / 2)
                    {
                        Console.WriteLine(word[i]);
                    }
                }
            }
        }
    }
}
