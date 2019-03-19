using System;
using System.Collections.Generic;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> word = new List<char>();

            foreach (char character in input)
            {
                char previousCharacter = word[word.Count - 1];

                if(!word.Contains(character) || character != previousCharacter)
                {
                    word.Add(character);
                }
            }

            string result = string.Join("", word);
            Console.WriteLine(result);
        }
    }
}
