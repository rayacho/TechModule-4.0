using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
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

			string command;

			while ((command = Console.ReadLine()) != "end")
			{
				string[] array = command.Split().ToArray();
				string action = array[0];

				switch (action)
				{
					case "Delete":
						int numberToDelete = int.Parse(array[1]);
						elements.Remove(numberToDelete);
						break;
					case "Insert":
						int numberToInsert = int.Parse(array[1]);
						int position = int.Parse(array[2]);
						elements.Insert(position, numberToInsert);
						break;
				}
			}

			foreach (int element in elements)
			{
				Console.Write(element + " ");
			}
		}
	}
}
