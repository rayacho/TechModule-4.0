using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
	class Program
	{
		static void Main()
		{
			List<Person> people = new List<Person>();
			string input = Console.ReadLine();

			while (input != "End")
			{
				people.Add(new Person(input.Split()));

				input = Console.ReadLine();
			}

			foreach (Person person in people.OrderBy(p => p.Age))
			{
				Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
			}
		}
	}

	public class Person
	{
		public string Name { get; set; }

		public string ID { get; set; }

		public int Age { get; set; }

		public Person(string[] personInfo)
		{
            if (personInfo == null)
            {
                throw new ArgumentNullException(nameof(personInfo));
            }

            Name = personInfo[0];
			ID = personInfo[1];
			Age = int.Parse(personInfo[2]);
		}
	}
}
