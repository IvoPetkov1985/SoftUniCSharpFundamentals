using System;

namespace _06._Triples_of_Latin_Letters_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = (int)'a'; i < (int)'a' + count; i++)
            {
                for (int j = (int)'a'; j < (int)'a' + count; j++)
                {
                    for (int k = (int)'a'; k < (int)'a' + count; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
