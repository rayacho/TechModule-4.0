using System;
using System.Collections.Generic;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string command = input[0];
                string user = input[1];

                switch (command)
                {
                    case "register":
                        string licensePlate = input[2];
                        if (!parkingLot.ContainsKey(user))
                        {
                            parkingLot.Add(user, licensePlate);
                            Console.WriteLine($"{user} registered {licensePlate} successfully");
                        }
                        else if (parkingLot.ContainsKey(user))
                        {
                            string plateNumber = parkingLot[user];
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (parkingLot.ContainsKey(user))
                        {
                            parkingLot.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        else if (!parkingLot.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        break;
                }
            }

            foreach (var person in parkingLot)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }
        }
    }
}
