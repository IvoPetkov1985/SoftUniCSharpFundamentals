using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            if (command == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstValue, secondValue));
            }
            else if (command == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (command == "string")
            {
                string firstText = Console.ReadLine();
                string secondText = Console.ReadLine();
                Console.WriteLine(GetMax(firstText, secondText));
            }
        }

        static string GetMax(string firstText, string secondText)
        {
            int result = firstText.CompareTo(secondText);

            if (result > 0)
            {
                return firstText;
            }
            else
            {
                return secondText;
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
