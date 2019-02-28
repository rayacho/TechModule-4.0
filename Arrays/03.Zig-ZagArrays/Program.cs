using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int[] first = new int[number];
			int[] second = new int[number];
			int j = 0;

			for(int i = 0; i < number; i++)
			{
				int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				if(i % 2 == 0 || i == 0)
				{
					first[j] = n[0];
					second[j] = n[1];
					j++;
				}
				else if(i % 2 != 0 || i == 1)
				{
					first[j] = n[1];
					second[j] = n[0];
					j++;
				}
			}

			foreach (int num in first)
			{
				Console.Write(num + " ");
			}

			Console.WriteLine();

			foreach (int num in second)
			{
				Console.Write(num + " ");
			}
		}
	}
}
