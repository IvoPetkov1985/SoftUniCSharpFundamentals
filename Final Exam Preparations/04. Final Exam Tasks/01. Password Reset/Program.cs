using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string predefined = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "Done")
            {
                string[] tokens = commandLine.Split(" ");
                string command = tokens[0];

                if (command == "TakeOdd")
                {
                    string pass = string.Empty;

                    for (int i = 0; i < predefined.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            pass += predefined[i].ToString();
                        }
                    }

                    predefined = pass;
                    Console.WriteLine(predefined);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);

                    string sequence = predefined.Substring(index, length);
                    int firstIndex = predefined.IndexOf(sequence);
                    predefined = predefined.Remove(firstIndex, length);
                    Console.WriteLine(predefined);
                }
                else if (command == "Substitute")
                {
                    string oldSubstring = tokens[1];
                    string newSubstring = tokens[2];

                    if (predefined.Contains(oldSubstring))
                    {
                        predefined = predefined.Replace(oldSubstring, newSubstring);
                        Console.WriteLine(predefined);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {predefined}");
        }
    }
}
