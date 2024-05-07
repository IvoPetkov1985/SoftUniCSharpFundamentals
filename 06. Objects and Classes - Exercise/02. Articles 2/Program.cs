using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = readArticle[0];
            string content = readArticle[1];
            string author = readArticle[2];

            Article article = new Article(title, content, author);

            int changesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < changesCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];
                string textToChange = tokens[1];

                switch (currentCommand)
                {
                    case "Edit":
                        article.Edit(textToChange);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(textToChange);
                        break;
                    case "Rename":
                        article.Rename(textToChange);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

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
