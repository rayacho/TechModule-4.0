using System;

namespace _06.TriplesOfLatinLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			int letters = int.Parse(Console.ReadLine());
			char character;

			for(int i = 0; i < letters; i++)
			{
				for(int j = 0; j < letters; j++)
				{
					for(int k = 0; k < letters; k++)
					{
						character = (char)('a' + i);
						Console.Write(character);
						character = (char)('a' + j);
						Console.Write(character);
						character = (char)('a' + k);
						Console.Write(character);
						Console.WriteLine();
					}
				}
			}
		}
	}
}
