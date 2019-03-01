using System;

namespace _10.TopNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i < n; i++)
			{
				if(IsDivisibleBy8(i) && OddDigit(i))
				{
					Console.WriteLine(i);
				}
			}
		}

		static bool IsDivisibleBy8(int number)
		{
			string numberArray = number.ToString();
			int sum = 0;
			foreach (char digit in numberArray)
			{
				sum += digit;
			}

			if(sum % 8 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool OddDigit(int number)
		{
			string numberArray = number.ToString();
			bool odd = false;
			foreach (char digit in numberArray)
			{
				if (digit % 2 != 0)
				{
					odd = true;
				}
			}

			return odd;
		}
	}
}
