using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			List<int> elements = new List<int>();

			foreach (int element in numbers)
			{
				elements.Add(element);
			}

			string command = Console.ReadLine();

			while (command != "End")
			{
				string[] fullCommand = command.Split().ToArray();
				string action = fullCommand[0];

				switch (action)
				{
					case "Add":
						int numberToAdd = int.Parse(fullCommand[1]);
						elements.Add(numberToAdd);

						break;

					case "Insert":
						int numberToInsert = int.Parse(fullCommand[1]);
						int position = int.Parse(fullCommand[2]);

						if (position >= elements.Count || position < 0)
						{
							Console.WriteLine("Invalid index");
						}
						else
						{
							elements.Insert(position, numberToInsert);
						}

						break;

					case "Remove":
						int index = int.Parse(fullCommand[1]);

						if (index >= elements.Count || index < 0)
						{
							Console.WriteLine("Invalid index");
						}
						else
						{
							elements.RemoveAt(index);
						}

						break;

					case "Shift":
						switch (fullCommand[1])
						{
							case "left":
								int countLeft = int.Parse(fullCommand[2]);

								for (int i = 0; i < countLeft; i++)
								{
									elements.Add(elements[0]);
									elements.RemoveAt(0);
								}

								break;

							case "right":
								int countRight = int.Parse(fullCommand[2]);

								for (int i = 0; i < countRight; i++)
								{
									elements.Insert(0, elements[elements.Count - 1]);
									elements.RemoveAt(elements.Count - 1);
								}

								break;
						}

						break;
					default:
						throw new Exception("Invalid command");
				}

                command = Console.ReadLine();
            }

			foreach (int element in elements)
			{
				Console.Write(element + " ");
			}
		}
	}
}
