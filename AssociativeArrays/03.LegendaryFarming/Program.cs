using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            items.Add("shadowmourne", 0);
            items.Add("valanyr", 0);
            items.Add("dragonwrath", 0);

            while (items["shadowmourne"] < 250 && items["valanyr"] < 250 && items["dragonwrath"] < 250)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int i = 0; i < line.Length; i += 2)
                {
                    int quality = int.Parse(line[i]);
                    string item = line[i + 1].ToLower();

                    if (items.ContainsKey(item))
                    {
                        items[item] += quality;
                    }
                    else if (junkItems.ContainsKey(item))
                    {
                        junkItems[item] += quality;
                    }
                    else
                    {
                        junkItems.Add(item, quality);
                    }
                }
            }

            if (items["shadowmourne"] >= 250)
            {
                Console.WriteLine($"Shadowmourne obtained!");
                items["shadowmourne"] -= 250;

                var sortedItems = items.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                foreach (var pair in sortedItems)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }

                List<string> sortedJunkItems = junkItems.Keys.ToList();
                sortedJunkItems.Sort();

                foreach (string key in sortedJunkItems)
                {
                    Console.WriteLine($"{key}: {junkItems[key]}");
                }
            }
            else if (items["valanyr"] >= 250)
            {
                Console.WriteLine($"Valanyr obtained!");
                items["valanyr"] -= 250;

                var sortedItems = items.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                foreach (var pair in sortedItems)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }

                List<string> sortedJunkItems = junkItems.Keys.ToList();
                sortedJunkItems.Sort();

                foreach (string key in sortedJunkItems)
                {
                    Console.WriteLine($"{key}: {junkItems[key]}");
                }
            }
            else if (items["dragonwrath"] >= 250)
            {
                Console.WriteLine($"Dragonwrath obtained!");
                items["dragonwrath"] -= 250;

                var sortedItems = items.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                foreach (var pair in sortedItems)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }

                List<string> sortedJunkItems = junkItems.Keys.ToList();
                sortedJunkItems.Sort();

                foreach (string key in sortedJunkItems)
                {
                    Console.WriteLine($"{key}: {junkItems[key]}");
                }
            }
        }
    }
}
