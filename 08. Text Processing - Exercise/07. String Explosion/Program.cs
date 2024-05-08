using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            int bombPower = 0;

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (bombPower > 0 && inputLine[i] != '>')
                {
                    inputLine = inputLine.Remove(i, 1);
                    bombPower--;
                    i--;
                }
                else if (inputLine[i] == '>')
                {
                    bombPower += int.Parse(inputLine[i + 1].ToString());
                }
            }

            Console.WriteLine(inputLine);
        }
    }
}
