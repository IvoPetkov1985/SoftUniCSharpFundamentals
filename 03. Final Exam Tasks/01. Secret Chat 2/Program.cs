using System;

namespace _01._Secret_Chat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string instructionsLine = Console.ReadLine();

            while (instructionsLine != "Reveal")
            {
                string[] tokens = instructionsLine.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(tokens[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string subText = tokens[1];

                    if (message.Contains(subText))
                    {
                        int startIndex = message.IndexOf(subText);
                        message = message.Remove(startIndex, subText.Length);

                        string resultText = string.Empty;

                        for (int i = subText.Length - 1; i >= 0; i--)
                        {
                            resultText += subText[i];
                        }

                        message = message.Insert(message.Length, resultText);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string oldSubstring = tokens[1];
                    string newSubstring = tokens[2];

                    if (message.Contains(oldSubstring))
                    {
                        message = message.Replace(oldSubstring, newSubstring);
                        Console.WriteLine(message);
                    }
                }

                instructionsLine = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
