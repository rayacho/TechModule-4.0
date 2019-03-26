using System;
using System.Text.RegularExpressions;

namespace _08.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            Regex regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
            MatchCollection collection = regex.Matches(numbers);

            foreach (object item in collection)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
