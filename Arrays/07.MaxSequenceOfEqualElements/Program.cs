using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int len = 1;
			int bestStart = 0;
			int bestLength = 1;

			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == array[i - 1])
				{
					len++;
					if (len > bestLength)
					{
						bestLength = len;
						bestStart = array[i];
					}
				}
				else
				{
					len = 1;
				}
			}

			for (int i = 0; i < bestLength; i++)
			{
				Console.Write(bestStart + " ");
			}
		}
	}
}
