using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());

            Dictionary<string, string[]> collection = new Dictionary<string, string[]>();

            for (int i = 1; i <= piecesCount; i++)
            {
                string pieceInfo = Console.ReadLine();
                string[] pieceTokens = pieceInfo.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = pieceTokens[0];
                string composer = pieceTokens[1];
                string key = pieceTokens[2];

                if (!collection.ContainsKey(piece))
                {
                    collection.Add(piece, new string[2]);
                    collection[piece][0] = composer;
                    collection[piece][1] = key;
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] tokens = commandLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string piece = tokens[1];

                if (command == "Add")
                {
                    string composer = tokens[2];
                    string key = tokens[3];

                    if (collection.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        collection[piece] = new string[2];
                        collection[piece][0] = composer;
                        collection[piece][1] = key;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    if (collection.ContainsKey(piece))
                    {
                        collection.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command == "ChangeKey")
                {
                    string newKey = tokens[2];

                    if (collection.ContainsKey(piece))
                    {
                        collection[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string[]> pieces in collection)
            {
                string piece = pieces.Key;
                string composer = pieces.Value[0];
                string key = pieces.Value[1];

                Console.WriteLine($"{piece} -> Composer: {composer}, Key: {key}");
            }
        }
    }
}
