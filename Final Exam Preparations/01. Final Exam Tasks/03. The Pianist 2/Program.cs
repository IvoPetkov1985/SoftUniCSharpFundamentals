using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());

            List<Piece> collection = new List<Piece>();

            for (int i = 0; i < piecesCount; i++)
            {
                string pieceInfo = Console.ReadLine();
                string[] pieceTokens = pieceInfo.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string pieceName = pieceTokens[0];
                string composer = pieceTokens[1];
                string key = pieceTokens[2];

                Piece piece = new Piece(pieceName, composer, key);
                collection.Add(piece);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] tokens = commandLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string pieceName = tokens[1];

                switch (command)
                {
                    case "Add":

                        string composer = tokens[2];
                        string key = tokens[3];

                        Piece nextPiece = collection.FirstOrDefault(x => x.Name == pieceName);
                        if (nextPiece == null)
                        {
                            Piece piece = new Piece(pieceName, composer, key);
                            collection.Add(piece);
                            Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{pieceName} is already in the collection!");
                        }

                        break;

                    case "Remove":

                        Piece pieceToRemove = collection.FirstOrDefault(x => x.Name == pieceName);
                        if (pieceToRemove != null)
                        {
                            collection.Remove(pieceToRemove);
                            Console.WriteLine($"Successfully removed {pieceName}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                        }

                        break;

                    case "ChangeKey":

                        string newKey = tokens[2];

                        Piece pieceToChange = collection.FirstOrDefault(x => x.Name == pieceName);

                        if (pieceToChange == null)
                        {
                            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                        }
                        else
                        {
                            pieceToChange.Key = newKey;
                            Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                        }

                        break;
                }

                commandLine = Console.ReadLine();
            }

            foreach (Piece piece in collection)
            {
                Console.WriteLine(piece);
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
