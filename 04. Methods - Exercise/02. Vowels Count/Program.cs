using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            VowelsCountPrinter(text);
        }

        static void VowelsCountPrinter(string word)
        {
            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char current = word[i];

                if (current == 'A' || current == 'O' || current == 'U' || current == 'E' || current == 'I' || current == 'Y'
                    || current == 'a' || current == 'o' || current == 'u' || current == 'e' || current == 'i' || current == 'y')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
