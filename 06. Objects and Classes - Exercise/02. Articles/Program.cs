using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string articleParts = Console.ReadLine();
            string[] articleTokens = articleParts.Split(", ");
            string title = articleTokens[0];
            string content = articleTokens[1];
            string author = articleTokens[2];

            Article article = new Article();

            article.Title = title;
            article.Content = content;
            article.Author = author;

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string text = tokens[1];

                if (command == "Edit")
                {
                    article.Edit(text);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(text);
                }
                else if (command == "Rename")
                {
                    article.Rename(text);
                }
            }

            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
