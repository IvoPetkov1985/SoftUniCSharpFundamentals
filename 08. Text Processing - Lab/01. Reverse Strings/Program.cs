using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToReverse = Console.ReadLine();

            while (wordToReverse != "end")
            {
                string reversed = string.Empty;

                for (int i = 0; i < wordToReverse.Length; i++)
                {
                    reversed += wordToReverse[wordToReverse.Length - 1 - i];
                }

                Console.WriteLine($"{wordToReverse} = {reversed}");

                wordToReverse = Console.ReadLine();
            }
        }
    }
}
