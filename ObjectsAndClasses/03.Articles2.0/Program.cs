using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Article> articles = new List<Article>();
			int numberOfArticles = int.Parse(Console.ReadLine());

			for (int i = 0; i < numberOfArticles; i++)
			{
				string[] input = Console.ReadLine().Split(", ").ToArray();
				string title = input[0];
				string content = input[1];
				string author = input[2];
				Article article = new Article(title, content, author);
				articles.Add(article);
			}

			string search = Console.ReadLine();

			switch (search)
			{
				case "title":
					articles = articles.OrderBy(x => x.Title).ToList();
					break;
				case "content":
					articles = articles.OrderBy(x => x.Content).ToList();
					break;
				case "author":
					articles = articles.OrderBy(x => x.Author).ToList();
					break;
			}

			foreach (Article article in articles)
			{
				Console.WriteLine(article.ToString());
			}
		}
	}

	public class Article
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
