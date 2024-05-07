using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int articlesCount = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < articlesCount; i++)
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

                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
