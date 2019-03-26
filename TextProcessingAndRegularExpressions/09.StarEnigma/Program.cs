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

                string DecryptedTostring = decryptedMessage.ToString();
                Match Matches = Regex.Match(DecryptedTostring, allregex);
                string Name = Matches.Groups["Name"].Value;
                string Population = Matches.Groups["population"].Value;
                string AorD = Matches.Groups["AorD"].Value;
                string Soldiers = Matches.Groups["soldiers"].Value;

                if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Population)
                    && !string.IsNullOrEmpty(AorD) && !string.IsNullOrEmpty(Soldiers))
                {
                    if (AorD.ToString() == "A")
                    {
                        attacked.Add(Name.ToString());
                    }
                    else if (AorD.ToString() == "D")
                    {
                        destroyed.Add(Name.ToString());
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
