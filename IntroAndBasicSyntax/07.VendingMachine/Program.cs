using System;

namespace _07.VendingMachine
{
	class Program
	{
		static void Main(string[] args)
		{
			double money = 0;
			string add;

			while ((add = Console.ReadLine()) != "Start")
			{
				double numberToAdd = double.Parse(add);
				if (numberToAdd != 0.1 && numberToAdd != 0.2 && numberToAdd != 0.5 && numberToAdd != 1 && numberToAdd != 2)
				{
					Console.WriteLine($"Cannot accept {numberToAdd}");
				}
				else money += numberToAdd;
			}

			while ((add = Console.ReadLine()) != "End")
			{
				string product = add;

				switch (product)
				{
					case "Nuts":
						{
							double price = 2.0;
							if (money >= price)
							{
								money -= price;
								Console.WriteLine($"Purchased {product.ToLower()}");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
						}
						break;
					case "Water":
						{
							double price = 0.7;
							if (money >= price)
							{
								money -= price;
								Console.WriteLine($"Purchased {product.ToLower()}");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
						}
						break;
					case "Crisps":
						{
							double price = 1.5;
							if (money >= price)
							{
								money -= price;
								Console.WriteLine($"Purchased {product.ToLower()}");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							};
						}
						break;
					case "Soda":
						{
							double price = 0.8;
							if (money >= price)
							{
								money -= price;
								Console.WriteLine($"Purchased {product.ToLower()}");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
						}
						break;
					case "Coke":
						{
							double price = 1.0;
							if (money >= price)
							{
								money -= price;
								Console.WriteLine($"Purchased {product.ToLower()}");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
						}
						break;
					default:
						Console.WriteLine($"Invalid product");
						break;
				}
			}
			Console.WriteLine($"Change: {money:F2}");
		}
	}
}
