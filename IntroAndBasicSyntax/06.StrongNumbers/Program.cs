using System;

namespace _06.StrongNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int backUpNumber = number;
			int sum = 0;

			while (number > 0)
			{
				int product = 1;
				int digit = number % 10;
				
				if (digit != 0)
				{
					for (int i = 1; i <= digit; i++)
					{
						product *= i;
					}

					sum += product;
				}

				number /= 10;
			}

			if (sum == backUpNumber)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}
