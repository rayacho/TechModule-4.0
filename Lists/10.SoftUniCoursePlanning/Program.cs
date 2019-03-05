using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> courses = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
			bool finish = false;

			while (!finish)
			{
				string input = Console.ReadLine();
				string[] command = input.Split(':');
				switch (command[0])
				{
					case "course start":
						int i = 1;

						foreach (string item in courses)
						{
							Console.WriteLine(i + "." + item);
							i++;
						}

						finish = true;
						break;

					case "Add":
						if (!courses.Contains(command[1]))
						{
							courses.Add(command[1]);
						}

						break;

					case "Insert":
						if (!courses.Contains(command[1]))
						{
							string title = command[1];
							int anotherIndex = int.Parse(command[2]);
							courses.Insert(anotherIndex, title);
						}

						break;

					case "Remove":
						string lessonToRemove = command[1];
						int index = courses.IndexOf(lessonToRemove);
						if (index + 1 < courses.Count)
						{
							if (courses.Contains(command[1]))
							{
								courses.Remove(lessonToRemove);
								List<string> newList = new List<string>();
								newList.Add(courses[index]);
								string newString = lessonToRemove + "-Exercise";
								if (newList[0] == newString)
								{
									courses.RemoveAt(index);
								}

							}
						}
						else
						{
							courses.Remove(lessonToRemove);
						}

						break;

					case "Swap":

						if (courses.Contains(command[1]) && courses.Contains(command[2]))
						{
							string firstCourse = command[1];
							string secondCourse = command[2];
							int indexOfFirstCourse = courses.IndexOf(firstCourse);
							int indexOfSecondCourse = courses.IndexOf(secondCourse);
							string firstSavedCourse = courses[indexOfFirstCourse];
							string secondSavedCourse = courses[indexOfSecondCourse];
							string firstStringToSearchFor = courses[indexOfFirstCourse] + "-Exercise";
							string secondStringToSearchFor = courses[indexOfSecondCourse] + "-Exercise";

							if (firstCourse != courses[courses.Count - 1] && courses[indexOfFirstCourse + 1] == firstStringToSearchFor)
							{
								courses[indexOfSecondCourse] = courses[indexOfFirstCourse];
								courses[indexOfFirstCourse] = secondCourse;
								courses.Insert(indexOfSecondCourse + 1, courses[indexOfFirstCourse + 1]);
								courses.RemoveAt(indexOfFirstCourse + 2);
							}
							else if (secondCourse != courses[courses.Count - 1] && courses[indexOfSecondCourse + 1] == secondStringToSearchFor)
							{
								courses[indexOfSecondCourse] = courses[indexOfFirstCourse];
								courses[indexOfFirstCourse] = secondCourse;
								courses.Insert(indexOfFirstCourse + 1, courses[indexOfSecondCourse + 1]);
								courses.RemoveAt(indexOfSecondCourse + 2);
							}
							else
							{
								courses[indexOfSecondCourse] = courses[indexOfFirstCourse];
								courses[indexOfFirstCourse] = secondCourse;
							}
						}

						break;

					case "Exercise":

						string stringToAdd = command[1] + "-Exercise";
						if (!courses.Contains(stringToAdd))
						{
							string LessionToAddExercise = command[1];
							if (courses.Contains(command[1]))
							{
								int indexOfCourse = courses.IndexOf(command[1]);
								courses.Insert(indexOfCourse + 1, stringToAdd);
							}
							else
							{
								courses.Add(command[1]);
								courses.Add(command[1] + "-Exercise");
							}
						}

						break;
				}
			}
		}
	}
}
