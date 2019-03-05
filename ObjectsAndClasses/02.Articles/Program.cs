using System;

namespace _02.Articles
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(", ").ToArray();
			string title = input[0];
			string content = input[1];
			string author = input[2];
			Article article = new Article(title, content, author);

			int numberOfCommands = int.Parse(Console.ReadLine());

			for (int i = 0; i < numberOfCommands; i++)
			{
				string[] command = Console.ReadLine().Split(": ").ToArray();
				switch (command[0])
				{
					case "Edit":
						article.Edit(command[1]);
						break;
					case "ChangeAuthor":
						article.ChangeAuthor(command[1]);
						break;
					case "Rename":
						article.Rename(command[1]);
						break;
				}
			}

			Console.WriteLine(article.ToString());
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
