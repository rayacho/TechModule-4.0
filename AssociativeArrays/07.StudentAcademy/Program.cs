using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    List<double> grades = new List<double>();
                    grades.Add(grade);

                    students.Add(name, grades);
                }
            }

            var newStudents = students.Where(x => x.Value.Average() >= 4.50).OrderByDescending(x => x.Value.Average());

            foreach (var student in newStudents)
            {
                double average = student.Value.Average();
                Console.WriteLine($"{student.Key} -> {average:F2}");
            }
        }
    }
}
