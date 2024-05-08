using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] filePath = inputLine.Split("\\", StringSplitOptions.RemoveEmptyEntries);
            string[] fileDetails = filePath[^1].Split(".");
            string fileName = fileDetails[0];
            string fileExtension = fileDetails[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
