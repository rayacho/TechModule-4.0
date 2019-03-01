using System;

namespace _06.MiddleCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Console.WriteLine(MiddleCharacter(input));
		}

		static string MiddleCharacter(string str)
		{
			if(str.Length % 2 == 0)
			{
				int firstIndex = str.Length / 2 - 1;
				int secondIndex = str.Length / 2;
				string output = $"{str[firstIndex]}{str[secondIndex]}";
				return output;
			}
			else
			{
				int middleIndex = str.Length / 2;
				string output = $"{str[middleIndex]}";
				return output;
			}
		}
	}
}
