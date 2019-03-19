using System;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigNumber = BigInteger.Parse(Console.ReadLine());
            int numberToMultiplyWith = int.Parse(Console.ReadLine());

            BigInteger result = bigNumber * numberToMultiplyWith;
            Console.WriteLine(result);
        }
    }
}
