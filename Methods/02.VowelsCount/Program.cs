using System;

namespace _02.VowelsCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			input = input.ToLower();
			int count = 0;

			foreach (char symbol in input)
			{
				if(IsVowel(symbol))
				{
					count++;
				}
			}

			Console.WriteLine(count);
		}

		static bool IsVowel(char a)
		{
			if(a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'y' || a == 'u')
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
