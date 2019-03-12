using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            string input = Console.ReadLine();

            foreach (char charElement in input)
            {
                if (charElement != ' ')
                {
                    if (chars.ContainsKey(charElement))
                    {
                        chars[charElement]++;
                    }
                    else
                    {
                        chars.Add(charElement, 1);
                    }
                }
            }

            foreach (var pair in chars)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
