using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 1; i <= numberOfSongs; i++)
            {
                string inputLine = Console.ReadLine();
                string[] songData = inputLine.Split("_");

                string type = songData[0];
                string name = songData[1];
                string duration = songData[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Duration = duration;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            switch (typeList)
            {
                case "all":

                    foreach (Song item in songs)
                    {
                        Console.WriteLine(item.Name);
                    }

                    break;

                default:

                    foreach (Song item in songs)
                    {
                        if (item.TypeList == typeList)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }

                    break;
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Duration { get; set; }
    }
}
