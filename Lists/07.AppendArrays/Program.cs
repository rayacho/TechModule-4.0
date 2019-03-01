using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split('|').Reverse().ToList();
			List<int> numbers = new List<int>();

			foreach (string array in input)
			{
				numbers.AddRange(array.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
			}

			foreach(int number in numbers)
			{
				Console.Write(number + " ");
			}
		}
	}
}
