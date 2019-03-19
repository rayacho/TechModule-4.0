using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                result += (char)(text[i] + 3);
            }

            Console.WriteLine(result);
        }
    }
}
