using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Song> songsList = new List<Song>();

            for (int i = 1; i <= songsCount; i++)
            {
                string dataLine = Console.ReadLine();
                string[] tokens = dataLine.Split("_");
                string type = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song song = new Song(type, name, time);
                songsList.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songsList.FindAll(s => s.TypeList == typeList))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string duration)
        {
            TypeList = typeList;
            Name = name;
            Time = duration;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
