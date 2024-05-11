using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<Participant> allParticipants = new List<Participant>();

            string commandLine = Console.ReadLine();

            while (commandLine != "dawn")
            {
                string[] tokens = commandLine.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(name) && songs.Contains(song))
                {
                    Participant participant = allParticipants.FirstOrDefault(x => x.Name == name);

                    if (participant == null)
                    {
                        participant = new Participant();
                        participant.Name = name;
                        participant.Songs.Add(song);

                        if (!participant.Awards.Contains(award))
                        {
                            participant.Awards.Add(award);
                        }

                        allParticipants.Add(participant);
                    }
                    else
                    {
                        participant.Songs.Add(song);

                        if (!participant.Awards.Contains(award))
                        {
                            if (award != null)
                            {
                                participant.Awards.Add(award);
                            }
                        }
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
                foreach (Participant participant in allParticipants.OrderByDescending(x => x.Awards.Count).ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{participant.Name}: {participant.Awards.Count} awards");

                    if (participant.Awards.Count > 0)
                    {
                        foreach (string award in participant.Awards.OrderBy(x => x))
                        {
                            Console.WriteLine($"--{award}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No awards");
                    }
                }
            }

        }
    }

    public class Participant
    {
        public Participant()
        {
            Songs = new List<string>();
            Awards = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Songs { get; set; }
        public List<string> Awards { get; set; }
    }
}
