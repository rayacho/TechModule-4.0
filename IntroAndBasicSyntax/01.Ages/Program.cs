using System;

namespace _01.Ages
{
	class Program
	{
		static void Main(string[] args)
		{
			int age = int.Parse(Console.ReadLine());
			bool baby = age >= 0 && age <= 2;
			bool child = age >= 3 && age <= 13;
			bool teenager = age >= 14 && age <= 19;
			bool adult = age >= 20 && age <= 65;
			bool elder = age >= 66;

			if(baby)
			{
				Console.WriteLine("baby");
			}
			else if(child)
			{
				Console.WriteLine("child");
			}
			else if(teenager)
			{
				Console.WriteLine("teenager");
			}
			else if(adult)
			{
				Console.WriteLine("adult");
			}
			else if(elder)
			{
				Console.WriteLine("elder");
			}
		}
	}
}
