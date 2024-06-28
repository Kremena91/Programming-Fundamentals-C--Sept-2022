using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            string[] input;

            for (int i = 0; i < countArticles; i++)
            {
                input = Console.ReadLine().Split(", ");

                Article article = new Article(input[0], input[1], input[2]);

                articles.Add(article);

            }
            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

