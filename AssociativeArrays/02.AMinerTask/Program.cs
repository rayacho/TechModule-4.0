using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> resources = new Dictionary<string, double>();
            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                double quality = double.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quality);
                }
                else
                {
                    resources[resource] += quality;
                }

                resource = Console.ReadLine();
            }

            foreach (KeyValuePair<string, double> miner in resources)
            {
                Console.WriteLine($"{miner.Key} -> {miner.Value}");
            }
        }
    }
}
