using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> guests = new List<string>();
			int number = int.Parse(Console.ReadLine());
			List<string> output = new List<string>();
			for(int i = 0; i < number; i++)
			{
				string[] guest = Console.ReadLine().Split();
				string name = guest[0];
				string going = guest[2];
				if(going == "going!")
				{
					if(guests.Contains(name))
					{
						output.Add($"{name} is already in the list!");
					}
					else
					{
						guests.Add(name);
					}
				}
				else
				{
					if (!guests.Contains(name))
					{
						output.Add($"{name} is not in the list!");
					}
					else
					{
						guests.Remove(name);
					}
				}
			}

			foreach (string line in output)
			{
				Console.WriteLine(line);
			}

			foreach (string guest in guests)
			{
				Console.WriteLine(guest);
			}
		}
	}
}
