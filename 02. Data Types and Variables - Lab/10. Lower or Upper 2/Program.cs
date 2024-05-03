using System;

namespace _10._Lower_or_Upper_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char givenLetter = char.Parse(Console.ReadLine());

            if (givenLetter >= 65 && givenLetter <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (givenLetter >= 97 && givenLetter <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
