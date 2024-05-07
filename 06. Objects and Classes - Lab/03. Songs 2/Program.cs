using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] songData = Console.ReadLine().Split("_");
                string type = songData[0];
                string name = songData[1];
                string time = songData[2];
                Song song = new Song(type, name, time);
                playlist.Add(song);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "all":
                    foreach (Song song in playlist)
                    {
                        Console.WriteLine(song.Name);
                    }
                    break;

                default:
                    foreach (Song song in playlist.FindAll(x => x.TypeList == command))
                    {
                        Console.WriteLine(song.Name);
                    }
                    break;
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Duration = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
    }
}
