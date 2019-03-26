﻿using System;
using System.Text.RegularExpressions;

namespace _12.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[0-9]+\.?[0-9]+)\$";

            string input = string.Empty;
            double totalIncome = 0.0;

            while (input != "end of shift")
            {
                input = Console.ReadLine();
                Regex order = new Regex(pattern);

                if (order.IsMatch(input))
                {
                    string customerName = order.Match(input).Groups["customer"].Value;
                    string productName = order.Match(input).Groups["product"].Value;
                    int count = int.Parse(order.Match(input).Groups["count"].Value);
                    double price = double.Parse(order.Match(input).Groups["price"].Value);

                    double totalPrice = price * count;

                    totalIncome += totalPrice;

                    Console.WriteLine($"{customerName}: {productName} - {totalPrice:F2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
