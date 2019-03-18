using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employ = new Dictionary<string, List<string>>();
          
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split(" -> ");
                string companyName = tokens[0];
                string employId = tokens[1];

                if (!employ.ContainsKey(companyName))
                {
                    employ[companyName] = new List<string>();
                    employ[companyName].Add(employId);
                }
                else if (employ[companyName].Contains(employId))
                {
                    continue;
                }
                else
                {
                    employ[companyName].Add(employId);
                }
            }

            foreach (var item in employ.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                List<string> sorted = item.Value;

                foreach (string employId in sorted)
                {
                    Console.WriteLine($"-- {employId}");
                }
            }
        }
    }
}

