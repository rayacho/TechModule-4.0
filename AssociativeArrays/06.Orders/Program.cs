using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] course = command.Split(" : ");
                string name = course[0];
                string student = course[1];

                if (courses.ContainsKey(name))
                {
                    courses[name].Add(student);
                }
                else
                {
                    List<string> students = new List<string>();
                    students.Add(student);

                    courses.Add(name, students);
                }

                command = Console.ReadLine();
            }

            var newCourses = courses.OrderByDescending(x => x.Value.Count);

            foreach (KeyValuePair<string, List<string>> course in newCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                List<string> students = course.Value.OrderBy(x => x).ToList();

                foreach (string student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
