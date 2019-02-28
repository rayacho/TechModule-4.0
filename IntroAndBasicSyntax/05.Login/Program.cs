using System;

namespace _05.Login
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			string password = Reverse(name);

			string personTry = Console.ReadLine();
			int number = 0;

			while (personTry != password)
			{
				Console.WriteLine("Incorrect password. Try again.");

				number++;
				personTry = Console.ReadLine();

				if (personTry != password && number == 3)
				{
					Console.WriteLine($"User {name} blocked!");
					return;
				}
			}

			Console.WriteLine($"User {name} logged in.");
		}

		public static string Reverse(string text)
		{
			char[] charArray = text.ToCharArray();
			string reverse = string.Empty;
			for (int i = charArray.Length - 1; i > -1; i--)
			{
				reverse += charArray[i];
			}
			return reverse;
		}
	}
}
