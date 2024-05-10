using System;
using System.Linq;

namespace _01._Secret_Chat_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageToReveal = Console.ReadLine();

            string instructionLine = Console.ReadLine();

            while (instructionLine != "Reveal")
            {
                string[] cmdArgs = instructionLine.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = cmdArgs.First();

                switch (currentCommand)
                {
                    case "InsertSpace":
                        int index = int.Parse(cmdArgs.Last());
                        messageToReveal = messageToReveal.Insert(index, " ");
                        break;

                    case "Reverse":
                        string substring = cmdArgs.Last();

                        if (messageToReveal.Contains(substring))
                        {
                            int startIndex = messageToReveal.IndexOf(substring);
                            messageToReveal = messageToReveal.Remove(startIndex, substring.Length);
                            string reversed = new string(substring.Reverse().ToArray());
                            messageToReveal = messageToReveal.Insert(messageToReveal.Length, reversed);
                        }
                        else
                        {
                            Console.WriteLine("error");
                            instructionLine = Console.ReadLine();
                            continue;
                        }
                        break;

                    case "ChangeAll":
                        string oldValue = cmdArgs[1];
                        string newValue = cmdArgs.Last();

                        if (messageToReveal.Contains(oldValue))
                        {
                            messageToReveal = messageToReveal.Replace(oldValue, newValue);
                        }
                        break;
                }

                Console.WriteLine(messageToReveal);
                instructionLine = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {messageToReveal}");
        }
    }
}
