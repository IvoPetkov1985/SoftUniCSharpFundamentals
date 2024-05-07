using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string currentPhrase = phrases[random.Next(0, phrases.Length)];
                string currentEvent = events[random.Next(0, events.Length)];
                string currentAuthor = authors[random.Next(0, authors.Length)];
                string currentCity = cities[random.Next(0, cities.Length)];

                Message message = new Message(currentPhrase, currentEvent, currentAuthor, currentCity);
                Console.WriteLine(message);
            }
        }
    }

    public class Message
    {
        public Message(string phrase, string eventment, string author, string city)
        {
            Phrase = phrase;
            Event = eventment;
            Author = author;
            City = city;
        }
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Phrase} {Event} {Author} – {City}.";
        }
    }
}
