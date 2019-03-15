using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstPersonCards = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondPersonCards = Console.ReadLine().Split().Select(int.Parse).ToList();
			int count = 0;

            while (true)
            {
                if (firstPersonCards[count] > secondPersonCards[count])
                {
					firstPersonCards.Add(firstPersonCards[count]);
					firstPersonCards.Add(secondPersonCards[count]);
					firstPersonCards.RemoveAt(count);
					secondPersonCards.RemoveAt(count);
                }
                else if (firstPersonCards[count] < secondPersonCards[count])
                {
					secondPersonCards.Add(secondPersonCards[count]);
					secondPersonCards.Add(firstPersonCards[count]);
					firstPersonCards.RemoveAt(count);
					secondPersonCards.RemoveAt(count);
                }
                else
                {
					firstPersonCards.RemoveAt(count);
					secondPersonCards.RemoveAt(count);
                }

                if (firstPersonCards.Count == 0 || secondPersonCards.Count == 0)
                {
                    break;
                }
            }

            if (firstPersonCards.Sum() > secondPersonCards.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstPersonCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPersonCards.Sum()}");
            }
		}
	}
}
