using System;

namespace _03.CharactersInRange
{
	class Program
	{
		static void Main(string[] args)
		{
			char startIndex = char.Parse(Console.ReadLine());
			char lastIndex = char.Parse(Console.ReadLine());
			string result = Range(startIndex, lastIndex);

			Console.Write(result);
			Console.WriteLine();
		}

		public static string Range(char startChar, char lastChar)
		{
			string range = null;

			if (startChar < lastChar)
			{
				for (int i = startChar + 1; i < lastChar; i++)
				{
					range += (char)i + " ";
				}
			}
			else
			{
				for (int i = lastChar + 1; i < startChar; i++)
				{
					range += (char)i + " ";
				}
			}

			return range + " ";
		}
	}
}
