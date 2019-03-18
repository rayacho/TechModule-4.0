using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "exam finished")
            {
                string[] info = command.Split("-");

                if (info.Length == 3)
                {
                    string username = info[0];
                    string language = info[1];
                    int points = int.Parse(info[2]);

                    if (!languageSubmissions.ContainsKey(language))
                    {
                        languageSubmissions.Add(language, 1);
                    }
                    else if (languageSubmissions.ContainsKey(language))
                    {
                        languageSubmissions[language]++;
                    }

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, points);
                    }
                    else if (users.ContainsKey(username))
                    {
                        if (points > users[username])
                        {
                            users[username] = points;
                        }
                    }
                }
                else if (info.Length == 2)
                {
                    string username = info[0];
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                }

                command = Console.ReadLine();
            }

            var orderedUsers = users.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            var orderedLanguageSubmissions = languageSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            Console.WriteLine("Results:");

            foreach (KeyValuePair<string, int> user in orderedUsers)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (KeyValuePair<string, int> language in orderedLanguageSubmissions)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
