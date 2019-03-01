using System;

namespace _05.AddAndSubstract
{
	class Program
	{
		static void Main(string[] args)
		{
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			int third = int.Parse(Console.ReadLine());

			int sumFirstAndSecond = Sum(first, second);
			int substraction = Substract(sumFirstAndSecond, third);

			Console.WriteLine(substraction);
		}

		static int Sum(int a, int b)
		{
			return a + b;
		}

		static int Substract(int a, int b)
		{
			return a - b;
		}
	}
}
