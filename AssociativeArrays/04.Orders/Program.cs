using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] input = command.Split(' ');
                string product = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

                List<double> priceAndQuantity = new List<double>();
                priceAndQuantity.Add(price);
                priceAndQuantity.Add(quantity);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, priceAndQuantity);
                }
                else
                {
                    products[product][1] += quantity;

                    if (products[product][0] != price)
                    {
                        products[product][0] = price;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var product in products)
            {
                string name = product.Key;
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{name} -> {totalPrice:F2}");
            }
        }
    }
}
