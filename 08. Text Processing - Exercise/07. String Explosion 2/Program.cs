using System;
using System.Text;

namespace _07._String_Explosion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            int bombPower = 0;

            for (int i = 0; i < inputLine.Length; i++)
            {
                char currentChar = inputLine[i];

                if (currentChar == '>')
                {
                    bombPower += int.Parse(inputLine[i + 1].ToString());
                }
                else if (bombPower > 0 && currentChar != '>')
                {
                    inputLine = inputLine.Remove(i, 1);
                    bombPower--;
                    i--;
                }
            }

            Console.WriteLine(inputLine);
        }
    }
}
