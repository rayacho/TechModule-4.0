using System;
using System.Linq;

namespace _05.TopInteger
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int j = 0;

			foreach (int number in array)
			{
				bool top = true;

				for(int i = j + 1; i < array.Length; i++)
				{
					if(number <= array[i])
					{
						top = false;
					}
				}

				if(top)
				{
					Console.Write(number + " ");
				}

				j++;
			}
		}
	}
}
