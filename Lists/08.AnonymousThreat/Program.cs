using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
			string command = Console.ReadLine();

			while (command != "3:1")
			{
				string[] tokens = command.Split();

				if (tokens[0] == "merge")
				{
					int startIndex = int.Parse(tokens[1]);
					int endIndex = int.Parse(tokens[2]);

					if (startIndex < 0)
					{
						startIndex = 0;
					}

					if (endIndex > input.Count - 1)
					{
						endIndex = input.Count - 1;
					}

					Merge(input, startIndex, endIndex);
				}
				else
				{
					int index = int.Parse(tokens[1]);
					int parts = int.Parse(tokens[2]);
					string element = input[index];
					input.RemoveAt(index);

					List<string> newWords = Divide(element, parts);
					input.InsertRange(index, newWords);
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", input));
		}

		private static List<string> Divide(string element, int parts)
		{
			List<string> newWords = new List<string>();
			int partLength = element.Length / parts;
			int lastPartLength = partLength + element.Length % parts;

			for (int i = 0; i < parts; i++)
			{
				string newWord = element.Substring(i * partLength, partLength);
				if (i == parts - 1)
				{
					newWord = element.Substring(i * partLength, lastPartLength);
				}

				newWords.Add(newWord);
			}

			return newWords;
		}

		private static void Merge(List<string> input, int startIndex, int endIndex)
		{
			string result = "";

			for (int i = startIndex; i <= endIndex; i++)
			{
				result += input[i];
			}

			input.RemoveRange(startIndex, endIndex - startIndex + 1);
			input.Insert(startIndex, result);
		}
	}
}
