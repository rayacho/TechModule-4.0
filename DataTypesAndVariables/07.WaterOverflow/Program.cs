﻿using System;

namespace _07.WaterOverflow
{
	class Program
	{
		static void Main(string[] args)
		{
			int capacity = 255;
			int lines = int.Parse(Console.ReadLine());
			int sumCapacity = 0;
			
			for(int line = 0; line < lines; line++)
			{
				int inputCapacity = int.Parse(Console.ReadLine());

				if(inputCapacity > capacity)
				{
					Console.WriteLine("Insufficient capacity!");
				}
				else
				{
					capacity -= inputCapacity;
					sumCapacity += inputCapacity;
				}
			}

			Console.WriteLine(sumCapacity);
		}
	}
}
