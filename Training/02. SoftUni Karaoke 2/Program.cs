using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaoke_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string[] availableSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string commandLine = Console.ReadLine();

            Dictionary<string, List<string>> allParticipants = new Dictionary<string, List<string>>();

            while (commandLine != "dawn")
            {
                string[] cmdArgs = commandLine.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs.First();
                string song = cmdArgs[1];
                string award = cmdArgs.Last();

                if (participants.Contains(name) && availableSongs.Contains(song))
                {
                    if (!allParticipants.ContainsKey(name))
                    {
                        allParticipants.Add(name, new List<string>());

                    }

                    if (!allParticipants[name].Contains(award))
                    {
                        allParticipants[name].Add(award);
                    }
                }

                commandLine = Console.ReadLine();
            }

            if (allParticipants.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (KeyValuePair<string, List<string>> kvp in allParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                    foreach (string award in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
