using System;

namespace _11.Snowballs
{
	class Program
	{
		static void Main(string[] args)
		{
			int snowballs = int.Parse(Console.ReadLine());
			double max = 0;
			int maxSnowballSnow = 0;
			int maxSnowballTime = 0;
			int maxSnowballQuality = 0;

			for(int i = 0; i < snowballs; i++)
			{
				int snowballSnow = int.Parse(Console.ReadLine());
				int snowballTime = int.Parse(Console.ReadLine());
				int snowballQuality = int.Parse(Console.ReadLine());
				double snowballValue = 1;

				//for (int j = 0; j < snowballQuality; j++)
				//{
				//	snowballValue *= (snowballSnow / snowballTime);
				//}

				snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);

				if(snowballValue > max)
				{
					max = snowballValue;
					maxSnowballQuality = snowballQuality;
					maxSnowballSnow = snowballSnow;
					maxSnowballTime = snowballTime;
				}
			}

			Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {max} ({maxSnowballQuality})");
		}
	}
}
