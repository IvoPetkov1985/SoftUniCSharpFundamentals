using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            CharPrinter(first, second);
        }

        static void CharPrinter(char a, char b)
        {
            if (b > a)
            {
                for (int i = (int)a + 1; i < (int)b; i++)
                {
                    char current = (char)i;
                    Console.Write(current + " ");
                }
            }
            else
            {
                for (int i = (int)b + 1; i < (int)a; i++)
                {
                    char current = (char)i;
                    Console.Write(current + " ");
                }
            }
        }
    }
}
