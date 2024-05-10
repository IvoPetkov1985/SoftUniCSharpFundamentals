using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._The_Pianist_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());
            List<Piece> compilation = new List<Piece>();

            for (int i = 0; i < piecesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] inputTokens = inputLine
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string pieceName = inputTokens.First();
                string composer = inputTokens[1];
                string key = inputTokens.Last();

                Piece piece = new Piece(pieceName, composer, key);
                compilation.Add(piece);
            }

            string commandLine = Console.ReadLine();

            while (true)
            {
                if (commandLine == "Stop")
                {
                    break;
                }

                string[] tokens = commandLine
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens.First();
                string piece = tokens[1];

                switch (command)
                {
                    case "Add":
                        string composer = tokens[2];
                        string key = tokens.Last();

                        Piece pieceToAdd = compilation.FirstOrDefault(x => x.Name == piece);

                        if (pieceToAdd == null)
                        {
                            pieceToAdd = new Piece(piece, composer, key);
                            compilation.Add(pieceToAdd);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;

                    case "Remove":
                        Piece pieceToRemove = compilation.FirstOrDefault(x => x.Name == piece);

                        if (pieceToRemove != null)
                        {
                            compilation.Remove(pieceToRemove);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        string newKey = tokens.Last();

                        Piece pieceToChange = compilation.FirstOrDefault(x => x.Name == piece);

                        if (pieceToChange != null)
                        {
                            pieceToChange.Key = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            foreach (Piece item in compilation)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Piece
    {
        public Piece(string name, string composer, string key)
        {
            this.Name = name;
            this.Composer = composer;
            this.Key = key;
        }
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }
}
