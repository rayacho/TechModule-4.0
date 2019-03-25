using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<string> input = text
                .Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int currentLength = 0;
            int start = 0;

            if (text[0] == '>')
            {
                start = 0;
            }
            else
            {
                start = 1;
            }

            for (int i = start; i < input.Count; i++)
            {
                char first = input[i].First();
                int strength = int.Parse(first.ToString());

                int length = input[i].Length;

                input[i] = new string(input[i].Skip(strength + currentLength).ToArray());

                if (strength + currentLength > length)
                {
                    currentLength = strength + currentLength - length;
                }
            }

            if (start == 0)
            {
                Console.WriteLine('>' + string.Join(">", input));
            }
            else
            {
                Console.WriteLine(string.Join(">", input));
            }
        }
    }
}
