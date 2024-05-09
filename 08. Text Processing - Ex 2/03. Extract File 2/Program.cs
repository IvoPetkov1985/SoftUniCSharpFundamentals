using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int index = input.LastIndexOf('\\');
            string file = input.Substring(index + 1);

            string[] fileDetails = file.Split('.');
            string fileName = fileDetails[0];
            string extension = fileDetails[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
