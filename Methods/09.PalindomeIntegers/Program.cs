using System;
using System.Linq;

namespace _09.PalindomeIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			string command;
			while((command = Console.ReadLine()) != "END")
			{
				int number = int.Parse(command);
				if(Palindrome(number))
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine("false");
				}
			}
		}

		static bool Palindrome(int number)
		{
			string forward = number.ToString();
			char[] forwardArray = forward.ToCharArray();
			string reverse = string.Empty;
			for (int i = forwardArray.Length - 1; i > -1; i--)
			{
				reverse += forwardArray[i];
			}

			if(forward == reverse)
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
