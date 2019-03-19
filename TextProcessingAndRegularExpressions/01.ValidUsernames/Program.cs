using System;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ").ToArray();

            foreach (string word in words)
            {
                bool valid = true;

                if (word.Length < 3 || word.Length > 16)
                {
                    valid = false;
                }

                foreach (char character in word)
                {
                    if (!char.IsLetterOrDigit(character) && character != '_' && character != '-')
                    {
                        valid = false;
                    }
                }

                if (valid)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
