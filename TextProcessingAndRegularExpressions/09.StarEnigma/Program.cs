using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _09.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"[SsTtAaRr]";
            string allregex = @"([^@\-!:>]*)@(?<Name>[A-Za-z+]+)([^@\-!:>]*):(?<population>[0-9]+)([^@\-!:>]*)!(?<AorD>[AD])!([^@\-!:>]*)->(?<soldiers>[\d]+)([^@\-!:>]*)";
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                string sequence = Console.ReadLine();
                MatchCollection matched = Regex.Matches(sequence, regex);
                StringBuilder decryptedMessage = new StringBuilder();
                int count = matched.Count();

                foreach (char item in sequence)
                {
                    decryptedMessage.Append((char)(item - count));
                }

                string decrypted = decryptedMessage.ToString();
                Match matches = Regex.Match(decrypted, allregex);
                string name = matches.Groups["Name"].Value;
                string population = matches.Groups["population"].Value;
                string aOrD = matches.Groups["AorD"].Value;
                string soldiers = matches.Groups["soldiers"].Value;

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(population)
                    && !string.IsNullOrEmpty(aOrD) && !string.IsNullOrEmpty(soldiers))
                {
                    if (aOrD.ToString() == "A")
                    {
                        attacked.Add(name.ToString());
                    }
                    else if (aOrD.ToString() == "D")
                    {
                        destroyed.Add(name.ToString());
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");

            foreach (string attackedPlanet in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {attackedPlanet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");

            foreach (string destroyedPlanet in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }
    }
}
