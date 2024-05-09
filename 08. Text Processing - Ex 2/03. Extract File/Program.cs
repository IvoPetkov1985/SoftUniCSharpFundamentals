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

            int extensionIndex = file.LastIndexOf('.');
            string extension = file.Substring(extensionIndex + 1);
            string fileName = file.Substring(0, file.Length - extension.Length - 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
