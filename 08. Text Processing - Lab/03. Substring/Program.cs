using System;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string text = Console.ReadLine();

            int startIndex = text.IndexOf(firstString);

            while (startIndex > -1)
            {
                text = text.Remove(startIndex, firstString.Length);

                startIndex = text.IndexOf(firstString);
            }

            Console.WriteLine(text);
        }
    }
}
