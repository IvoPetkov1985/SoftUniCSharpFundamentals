using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int articlesCount = int.Parse(Console.ReadLine());

            List<Article> articlesList = new List<Article>();

            for (int i = 0; i < articlesCount; i++)
            {
                string[] articleTokens = Console.ReadLine().Split(", ");
                string title = articleTokens[0];
                string content = articleTokens[1];
                string author = articleTokens[2];

                Article article = new Article(title, content, author);
                articlesList.Add(article);
            }

            Console.WriteLine(string.Join(Environment.NewLine, articlesList));

            //string command = Console.ReadLine();

            //switch (command)
            //{
            //    case "title":
            //        foreach (Article current in articlesList.OrderByDescending(x => x.Title))
            //        {
            //            Console.WriteLine(current);
            //        }
            //        break;
            //    case "content":
            //        foreach (Article current in articlesList.OrderByDescending(x => x.Content))
            //        {
            //            Console.WriteLine(current);
            //        }
            //        break;
            //}
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


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
