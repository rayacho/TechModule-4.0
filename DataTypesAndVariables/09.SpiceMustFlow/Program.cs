using System;

namespace _09.SpiceMustFlow
{
	class Program
	{
		static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int days = 0;
			int consume = 26;
			int spices = 0;

			while (start >= 100)
			{
				if(start <= consume)
				{
					start = 0;
				}

				days++;
				spices = spices + start - consume;
				start = start - 10;
			}

			if (start < 100)
			{
				if (spices >= consume)
				{
					spices -= consume;
				}
			}
			else
			{
				Console.WriteLine("Yield cannot be null");
				return;
			}

			Console.WriteLine(days);
			Console.WriteLine(spices);
		}
	}
}
