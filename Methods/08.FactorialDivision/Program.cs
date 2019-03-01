using System;

namespace _08.FactorialDivision
{
	class Program
	{
		static void Main(string[] args)
		{
			long first = long.Parse(Console.ReadLine());
			long second = long.Parse(Console.ReadLine());
			double division = Factorial(first) / Factorial(second);
			string result = $"{division:F2}";

			Console.WriteLine(result);
		}

		static double Factorial(double a)
		{
			if (a == 0)
			{
				return 1;
			}
			else
			{
				int factorial = 1;

				for (int i = 2; i <= a; i++)
				{
					factorial *= i;
				}

				return factorial;
			}
		}
	}
}
