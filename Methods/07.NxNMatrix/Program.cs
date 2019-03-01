using System;

namespace _07.NxNMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			Matrix(number);

		}
		static void Matrix(int n)
		{
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					Console.Write(n + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
