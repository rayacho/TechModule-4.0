using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] tokens = input.Split(" | ").ToArray();
                    bool doesSideExist = false;
                    bool doesUserExist = false;

                    foreach (KeyValuePair<string, List<string>> side in forces)
                    {
                        if (side.Value.Contains(tokens[1]))
                        {
                            doesUserExist = true;
                        }

                        if (side.Key == tokens[0])
                        {
                            doesSideExist = true;
                        }
                    }

                    if (!doesUserExist)
                    {
                        if (doesSideExist)
                        {
                            forces[tokens[0]].Add(tokens[1]);
                        }
                        else
                        {
                            forces.Add(tokens[0], new List<string>());
                            forces[tokens[0]].Add(tokens[1]);
                        }
                    }
                }

                else
                {
                    string[] tokens = input.Split(" -> ").ToArray();
                    bool doesSideExist = false;
                    string tempUser = tokens[0];

                    foreach (KeyValuePair<string, List<string>> side in forces)
                    {
                        if (side.Value.Contains(tokens[0]))
                        {
                            side.Value.Remove(tokens[0]);

                        }

                        if (side.Key == tokens[1])
                        {
                            doesSideExist = true;
                        }
                    }

                    if (doesSideExist)
                    {
                        forces[tokens[1]].Add(tempUser);
                    }
                    else
                    {
                        forces.Add(tokens[1], new List<string>());
                        forces[tokens[1]].Add(tempUser);
                    }

                    Console.WriteLine($"{tokens[0]} joins the {tokens[1]} side!");

                }

                input = Console.ReadLine();
            }

            var sortedForces = forces.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            foreach (KeyValuePair<string, List<string>> side in sortedForces)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    var sortedUsers = side.Value.OrderBy(x => x);

                    foreach (string user in sortedUsers)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }

            }
        }
    }
}
