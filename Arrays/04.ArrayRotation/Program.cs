using System;
using System.Linq;

namespace _04.ArrayRotation
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int startIndex = int.Parse(Console.ReadLine());

			if(startIndex > array.Length)
			{
				startIndex = startIndex - array.Length;

				for(int i = startIndex; i < array.Length; i++)
				{
					Console.Write(array[i] + " ");
				}

				for(int i = 0; i < startIndex; i++)
				{
					Console.Write(array[i] + " ");
				}
			}
			else
			{
				for (int i = startIndex; i < array.Length; i++)
				{
					Console.Write(array[i] + " ");
				}

				for (int i = 0; i < startIndex; i++)
				{
					Console.Write(array[i] + " ");
				}
			}
		}
	}
}
