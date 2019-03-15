using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>();
			int numberOfStudents = int.Parse(Console.ReadLine());

			for (int i = 0; i < numberOfStudents; i++)
			{
				string[] input = Console.ReadLine().Split(" ").ToArray();
				string firstName = input[0];
				string lastName = input[1];
				double grade = double.Parse(input[2]);
				Student student = new Student(firstName, lastName, grade);

				students.Add(student);
			}

			students = students.OrderByDescending(x => x.Grade).ToList();

			foreach (Student student in students)
			{
				Console.WriteLine(student.ToString());
			}
		}
	}

	public class Student
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public double Grade { get; set; }

		public Student(string firstName, string lastName, double grade)
		{
			FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
			LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
			Grade = grade;
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName}: {Grade:F2}";
		}
	}
}
