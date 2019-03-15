using System;
using System.Linq;

namespace _08.MagicSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int neededSum = int.Parse(Console.ReadLine());
			int j = 0;

			foreach (int num in nums)
			{
				int sum = nums[j];

				for(int i = j + 1; i < nums.Length; i++)
				{
					sum += nums[i];

					if(sum == neededSum)
					{
						Console.WriteLine($"{nums[j]} {nums[i]}");
					}

					sum = nums[j];
				}

				j++;
			}
		}
	}
}
