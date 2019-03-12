using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] productInfo = command.Split(' ');
                string name = productInfo[0];
                double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Dictionary<double, int>());
                    products[name].Add(price, quantity);
                }
                else
                {
                    if (!products[name].ContainsKey(price))
                    {
                        products[name]
                    }
                }
            }
        }
    }
}
