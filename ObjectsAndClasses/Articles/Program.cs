using System;
using System.Linq;

namespace Articles
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

			int number = int.Parse(Console.ReadLine());

			for(int i = 0; i < number; i++)
			{
				string[] allCommand = Console.ReadLine().Split(':');
				string command = allCommand[0];
				string replacement = allCommand.Where(val => val != command).ToString();
				switch(command)
				{
					case "Edit":
						article.Edit(replacement);
						break;
					case "ChangeAuthor":
						article.ChangeAuthor(replacement);
						break;
					case "Rename":
						article.Rename(replacement);
						break;
				}
			}

			Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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
		
		public void Edit(string newContent)
		{
			Content = newContent;
		}

		public void ChangeAuthor(string newName)
		{
			Author = newName;
		}

		public void Rename(string newName)
		{
			Title = newName;
		}

		public override string ToString()
		{
			return $"{Title} - {Content}: {Author}";
		}
	}
}
