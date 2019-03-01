using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			List<int> elements = new List<int>();

			foreach (int element in input)
			{
				elements.Add(element);
			}

			int[] bombInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int bombNumber = bombInput[0];
			int bombPower = bombInput[1];
			int sum = 0;

			for (int i = 0; i < elements.Count; i++)
			{
				if (elements.Contains(bombNumber))
				{
					int bombIndex = 0;
					for (int j = 0; j < elements.Count; j++)
					{
						if (elements[j] == bombNumber)
						{
							bombIndex = j;

							for (int p = 0; p < Math.Abs(bombPower); p++)
							{
								try
								{
									elements.RemoveAt(j - 1 - p);
									bombIndex--;
								}
								catch
								{
									break;
								}
							}

							for (int l = 0; l < Math.Abs(bombPower); l++)
							{
								try
								{
									elements.RemoveAt(bombIndex + 1);
								}
								catch
								{
									break;
								}
							}

							elements.RemoveAt(bombIndex);
						}
					}
				}
			}

			for (int i = 0; i < elements.Count; i++)
			{
				sum += elements[i];
			}

			Console.WriteLine(sum);
		}
	}
}
