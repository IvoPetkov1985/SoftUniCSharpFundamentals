using System;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "Decode")
            {
                string[] tokens = commandLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(tokens[1]);
                    string sequenceToMove = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters);
                    message = message.Insert(message.Length, sequenceToMove);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string value = tokens[2];
                    message = message.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string oldValue = tokens[1];
                    string newValue = tokens[2];

                    if (message.Contains(oldValue))
                    {
                        message = message.Replace(oldValue, newValue);
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
