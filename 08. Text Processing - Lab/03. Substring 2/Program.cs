using System;

namespace _03._Substring_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string inputText = Console.ReadLine();

            while (inputText.Contains(substringToRemove))
            {
                int index = inputText.IndexOf(substringToRemove);

                inputText = inputText.Remove(index, substringToRemove.Length);
            }

            Console.WriteLine(inputText);
        }
    }
}
