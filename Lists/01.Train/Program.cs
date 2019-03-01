using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			List<int> train = new List<int>();

			foreach (int wagon in input)
			{
				train.Add(wagon);
			}

			int maxCapacity = int.Parse(Console.ReadLine());
			string command;

			while ((command = Console.ReadLine()) != "end")
			{
				string[] array = command.Split().ToArray();
				string action = array[0];

				switch (action)
				{
					case "Add":
						int number = int.Parse(array[1]);
						train.Add(number);
						break;
					default:
						int passengers = int.Parse(action);

						for(int i = 0; i < train.Count; i++)
						{
							if (train[i] + passengers <= maxCapacity)
							{
								train[i] += passengers;
								break;
							}
						}
						break;
				}
			}

			foreach (int wagon in train)
			{
				Console.Write(wagon + " ");
			}
		}
	}
}
