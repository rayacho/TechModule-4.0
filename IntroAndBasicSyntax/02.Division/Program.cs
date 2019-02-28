using System;

namespace _02.Division
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			bool ten = number % 10 == 0;
			bool seven = number % 7 == 0;
			bool six = number % 6 == 0;
			bool three = number % 3 == 0;
			bool two = number % 2 == 0;

			if(ten)
			{
				Console.WriteLine($"The number is divisible by 10");
			}
			else if(seven)
			{
				Console.WriteLine($"The number is divisible by 7");
			}
			else if(six)
			{
				Console.WriteLine($"The number is divisible by 6");
			}
			else if(three)
			{
				Console.WriteLine($"The number is divisible by 3");
			}
			else if(two)
			{
				Console.WriteLine($"The number is divisible by 2");
			}
			else
			{
				Console.WriteLine("Not divisible");
			}
		}
	}
}
