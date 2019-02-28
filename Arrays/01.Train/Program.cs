using System;

namespace _01.Train
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int[] train = new int[number];
			int sum = 0;

			for(int i = 0; i < number; i++)
			{
				int vagon = int.Parse(Console.ReadLine());
				train[i] = vagon;
				sum += vagon;
			}

			foreach (int vagon in train)
			{
				Console.Write(vagon + " ");
			}

			Console.WriteLine();
			Console.WriteLine(sum);
		}
	}
}
