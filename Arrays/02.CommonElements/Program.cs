using System;

namespace _02.CommonElements
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] first = Console.ReadLine().Split();
			string[] second = Console.ReadLine().Split();

			for (int i = 0; i < first.Length; i++)
			{
				for (int j = 0; j < second.Length; j++)
				{
					if (second[j] == first[i])
					{
						Console.Write(second[j] + " ");
					}
				}
			}
		}
	}
}
