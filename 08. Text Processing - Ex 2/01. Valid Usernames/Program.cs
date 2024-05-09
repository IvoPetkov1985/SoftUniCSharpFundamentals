using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] names = inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];
                bool isValid = true;

                if (!(currentName.Length >= 3 && currentName.Length <= 16))
                {
                    isValid = false;
                }

                foreach (char symbol in currentName)
                {
                    if (!(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_'))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(currentName);
                }
            }
        }
    }
}
