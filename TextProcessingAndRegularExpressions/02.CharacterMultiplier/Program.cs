using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string firstWord = words[0];
            string secondWord = words[1];
            int result = Multiply(firstWord, secondWord);

            Console.WriteLine(result);
        }

        static int Multiply(string str1, string str2)
        {
            int result = 0;
            int firstWordLength = str1.Length;
            int secondWordLength = str2.Length;

            if (firstWordLength > secondWordLength)
            {
                for (int i = 0; i < secondWordLength; i++)
                {
                    result += str1[i] * str2[i];
                }

                for (int i = secondWordLength; i < firstWordLength; i++)
                {
                    result += str1[i];
                }
            }
            else if (secondWordLength > firstWordLength)
            {
                for (int i = 0; i < firstWordLength; i++)
                {
                    result += str1[i] * str2[i];
                }

                for (int i = firstWordLength; i < secondWordLength; i++)
                {
                    result += str2[i];
                }
            }
            else
            {
                for (int i = 0; i < firstWordLength; i++)
                {
                    result += str1[i] * str2[i];
                }
            }

            return result;
        }
    }
}
