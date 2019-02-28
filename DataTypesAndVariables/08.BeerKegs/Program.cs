using System;

namespace _08.BeerKegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int kegs = int.Parse(Console.ReadLine());
			double max = 0;
			string maxModel = "";

			for (int i = 0; i < kegs; i++)
			{
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());
				double volume = Math.PI * radius * radius * height;

				if (volume > max)
				{
					max = volume;
					maxModel = model;
				}
			}

			Console.WriteLine(maxModel);
		}
	}
}
