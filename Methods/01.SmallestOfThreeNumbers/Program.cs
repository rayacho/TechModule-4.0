using System;

namespace _01.SmallestOfThreeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			int third = int.Parse(Console.ReadLine());

			Console.WriteLine(SmallestNumber(first, second, third));
		}
		static int SmallestNumber(int a, int b, int c)
		{
			int min = a;
			if(b < min)
			{
				min = b;
			}
			if(c < min)
			{
				min = c;
			}

			return min;
		}
	}
}
