using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            int sumChars = 0;

            for (int i = 1; i <= linesCount; i++)
            {
                char currentLetter = char.Parse(Console.ReadLine());
                sumChars += (int)currentLetter;
            }

            Console.WriteLine("The sum equals: {0}", sumChars);
        }
    }
}
