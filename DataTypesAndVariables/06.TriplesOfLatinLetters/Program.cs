using System;

namespace _06.TriplesOfLatinLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			int letters = int.Parse(Console.ReadLine());
			char character;

			for(int firstLetter = 0; firstLetter < letters; firstLetter++)
			{
				for(int secondLetter = 0; secondLetter < letters; secondLetter++)
				{
					for(int thirdLetter = 0; thirdLetter < letters; thirdLetter++)
					{
						character = (char)('a' + firstLetter);
						Console.Write(character);

						character = (char)('a' + secondLetter);
						Console.Write(character);

						character = (char)('a' + thirdLetter);
						Console.Write(character);

						Console.WriteLine();
					}
				}
			}
		}
	}
}
