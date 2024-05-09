using System;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            while (inputString != "end")
            {
                StringBuilder reversedString = new StringBuilder();

                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    reversedString.Append(inputString[i]);
                }

                Console.WriteLine($"{inputString} = {reversedString}");

                inputString = Console.ReadLine();
            }
        }
    }
}
