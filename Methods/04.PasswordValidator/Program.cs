using System;
using System.Linq;

namespace _04.PasswordValidator
{
	class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();
			bool valid = true;

			if(!CheckLength(password))
			{
				valid = false;
				Console.WriteLine("Password must be between 6 and 10 characters");
			}

			if(!Consistency(password))
			{
				valid = false;
				Console.WriteLine("Password must consist only of letters and digits");
			}

			if(!Digits(password))
			{
				valid = false;
				Console.WriteLine("Password must have at least 2 digits");
			}

			if(valid)
			{
				Console.WriteLine("Password is valid");
			}
		}

		static bool CheckLength(string input)
		{
			if (input.Length >= 6 && input.Length <= 10)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool Consistency(string input)
		{
			if(input.All(char.IsLetterOrDigit))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool Digits(string input)
		{
			int count = 0;
			foreach (char value in input)
			{
				if (value >= '0' && value <= '9')
				{
					count++;
				}
			}

			if(count >= 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
