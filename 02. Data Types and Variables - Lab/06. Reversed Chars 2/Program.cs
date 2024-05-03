using System;

namespace _06._Reversed_Chars_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string concatenated = string.Empty;

            for (int i = 1; i <= 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                if (i != 3)
                {
                    concatenated += $"{symbol} ";
                }
                else
                {
                    concatenated += symbol;
                }
            }

            string reversed = string.Empty;

            for (int i = concatenated.Length - 1; i >= 0; i--)
            {
                reversed += concatenated[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
