using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double money = 0;
            double price;

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        price = 8.45;
                        money = price * people;
                        if (people >= 30)
                        {
                            money = money - (money * 0.15);
                        }
                    }
                    else if (type == "Business")
                    {
                        price = 10.90;
                        money = price * people;
                        if (people >= 100)
                        {
                            money = money - (10 * price);
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = 15;
                        money = people * price;
                        if (people >= 10 && people <= 20)
                        {
                            money = money - (0.05 * money);
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                    break;

                case "Saturday":
                    if (type == "Students")
                    {
                        price = 9.80;
                        money = price * people;
                        if (people >= 30)
                        {
                            money = money - (money * 0.15);
                        }
                    }
                    else if (type == "Business")
                    {
                        price = 15.60;
                        money = price * people;
                        if (people >= 100)
                        {
                            money = money - (10 * price);
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = 20;
                        money = people * price;
                        if (people >= 10 && people <= 20)
                        {
                            money = money - (0.05 * money);
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                    break;

                case "Sunday":
                    if (type == "Students")
                    {
                        price = 10.46;
                        money = price * people;
                        if (people >= 30)
                        {
                            money = money - (money * 0.15);
                        }
                    }
                    else if (type == "Business")
                    {
                        price = 16;
                        money = price * people;
                        if (people >= 100)
                        {
                            money = money - (10 * price);
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = 22.50;
                        money = people * price;
                        if (people >= 10 && people <= 20)
                        {
                            money = money - (0.05 * money);
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                    break;
            }

            Console.WriteLine($"Total price: {money:F2}");
        }
    }
}
