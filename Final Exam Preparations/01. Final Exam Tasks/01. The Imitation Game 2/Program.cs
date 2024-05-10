using System;

namespace _01._The_Imitation_Game_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commandLine = Console.ReadLine();

            while (commandLine != "Decode")
            {
                string[] instructions = commandLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = instructions[0];

                switch (currentCommand)
                {
                    case "Move":
                        int lettersCount = int.Parse(instructions[1]);
                        string subText = message.Substring(0, lettersCount);
                        message = message.Remove(0, lettersCount);
                        message = message.Insert(message.Length, subText);
                        break;

                    case "Insert":
                        int index = int.Parse(instructions[1]);
                        string value = instructions[2];
                        message = message.Insert(index, value);
                        break;

                    case "ChangeAll":
                        string substring = instructions[1];
                        string replacement = instructions[2];
                        message = message.Replace(substring, replacement);
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
