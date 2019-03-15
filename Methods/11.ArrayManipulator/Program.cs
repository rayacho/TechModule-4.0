using System;
using System.Linq;

namespace _11.ArrayManipulator
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			string fakeCommand = Console.ReadLine();

			while (fakeCommand != "end")
			{
				string[] command = fakeCommand.Split().ToArray();
				switch (command[0])
				{
					case "exchange":
						int index = int.Parse(command[1]);

						if (index > input.Length - 1 || index < 0)
						{
							Console.WriteLine("Invalid index");
						}
						else
						{
							input = Exchange(input, index);
						}
						break;

					case "max":
						string maxEvenOrOdd = command[1];

						if (maxEvenOrOdd == "even")
						{
							int k = MaxEven(input)[0];
							int maxIndex = MaxEven(input)[1];

							if (k == int.MinValue)
							{
								Console.WriteLine("No matches");
							}
							else
							{
								Console.WriteLine(maxIndex);
							}
						}
						else if (maxEvenOrOdd == "odd")
						{
							int k = MaxOdd(input)[0];
							int maxIndex = MaxOdd(input)[1];

							if (k == int.MinValue)
							{
								Console.WriteLine("No matches");
							}
							else
							{
								Console.WriteLine(maxIndex);
							}
						}

						break;

					case "min":
						string minEvenOrOdd = command[1];

						if (minEvenOrOdd == "even")
						{
							int k = MinEven(input)[0];
							int minIndex = MinEven(input)[1];

							if (k == int.MinValue)
							{
								Console.WriteLine("No matches");
							}
							else
							{
								Console.WriteLine(minIndex);
							}
						}
						else if (minEvenOrOdd == "odd")
						{
							int k = MinOdd(input)[0];
							int minIndex = MinOdd(input)[1];

							if (k == int.MinValue)
							{
								Console.WriteLine("No matches");
							}
							else
							{
								Console.WriteLine(minIndex);
							}
						}

						break;

					case "first":
						int firstCount = int.Parse(command[1]);

						if (firstCount > input.Length || firstCount < 0)
						{
							Console.WriteLine("Invalid count");
						}
						else
						{
							string needed = command[2];
							if (needed == "even")
							{
								FirstEven(input, firstCount);
							}
							else if (needed == "odd")
							{
								FirstOdd(input, firstCount);
							}
						}

						break;

					case "last":
						int lastCount = int.Parse(command[1]);

						if (lastCount > input.Length || lastCount < 0)
						{
							Console.WriteLine("Invalid count");
						}
						else
						{
							string needed = command[2];
							if (needed == "even")
							{
								LastEven(input, lastCount);
							}
							else if (needed == "odd")
							{
								LastOdd(input, lastCount);
							}
						}

						break;

                    default:
                        throw new ArgumentException();
				}
			}

			Console.WriteLine('[' + string.Join(", ", input) + ']');

            fakeCommand = Console.ReadLine();
		}

		private static int[] Exchange(int[] input, int index)
		{
			int[] output = new int[input.Length];
			int j = 0;

			for (int i = index + 1; i <= input.Length - 1; i++)
			{
				output[j] = input[i];
				j++;
			}

			for (int i = 0; i <= index; i++)
			{
				output[j] = input[i];
				j++;
			}

			return output;
		}

		private static int[] MaxOdd(int[] input)
		{
			int[] indexes = new int[2];
			int maxOddIndex = 0;
			int k = int.MinValue;

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] % 2 != 0)
				{
					maxOddIndex = i;
					k = i;
					break;
				}
			}

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] % 2 != 0 && input[i] >= input[maxOddIndex])
				{
					maxOddIndex = i;
				}
			}

			indexes[0] = k;
			indexes[1] = maxOddIndex;

			return indexes;
		}

		private static int[] MaxEven(int[] input)
		{
			int[] indexes = new int[2];
			int maxEvenIndex = 0;
			int k = int.MinValue;

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] % 2 == 0)
				{
					maxEvenIndex = i;
					k = i;
					break;
				}
			}

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] % 2 == 0 && input[i] >= input[maxEvenIndex])
				{
					maxEvenIndex = i;
				}
			}

			indexes[0] = k;
			indexes[1] = maxEvenIndex;

			return indexes;
		}

		private static int[] MinOdd(int[] input)
		{
			int[] indexes = new int[2];
			int minOddIndex = 0;
			int k = int.MinValue;

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] % 2 != 0)
				{
					minOddIndex = i;
					k = i;
					break;
				}
			}

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] % 2 != 0 && input[i] <= input[minOddIndex])
				{
					minOddIndex = i;
				}
			}

			indexes[0] = k;
			indexes[1] = minOddIndex;

			return indexes;
		}

		private static int[] MinEven(int[] input)
		{
			int[] indexes = new int[2];
			int minEvenIndex = 0;
			int k = int.MinValue;

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] % 2 == 0)
				{
					minEvenIndex = i;
					k = i;
					break;
				}
			}

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] % 2 == 0 && input[i] <= input[minEvenIndex])
				{
					minEvenIndex = i;
				}
			}

			indexes[0] = k;
			indexes[1] = minEvenIndex;

			return indexes;
		}

		private static void FirstEven(int[] input, int count)
		{
			int countEven = 0;
			int[] output = new int[count];

			for (int i = 0; i < input.Length; i++)
			{
				if (countEven >= count)
				{
					break;
				}
				else
				{
					if (input[i] % 2 == 0)
					{
						output[countEven] = input[i];
						countEven++;
					}
				}
			}

			int[] result = new int[countEven];

			for (int i = 0; i < countEven; i++)
			{
				result[i] = output[i];
			}

			if (output.Sum() == 0)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Console.WriteLine("[" + string.Join(", ", result) + "]");
			}
		}

		private static void FirstOdd(int[] input, int count)
		{
			int countOdd = 0;
			int[] output = new int[count];

			for (int i = 0; i < input.Length; i++)
			{
				if (countOdd >= count)
				{
					break;
				}
				else
				{
					if (input[i] % 2 != 0)
					{
						output[countOdd] = input[i];
						countOdd++;
					}
				}
			}

			int[] result = new int[countOdd];

			for (int i = 0; i < countOdd; i++)
			{
				result[i] = output[i];
			}

			if (output.Sum() == 0)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Console.WriteLine("[" + string.Join(", ", result) + "]");
			}
		}

		private static void LastEven(int[] input, int count)
		{
			int countEven = 0;
			int[] output = new int[count];

			for (int i = input.Length - 1; i >= 0; i--)
			{
				if (countEven >= count)
				{
					break;
				}
				else
				{
					if (input[i] % 2 == 0)
					{
						output[countEven] = input[i];
						countEven++;
					}
				}
			}

			int[] result = new int[countEven];
			int length = countEven - 1;

			for (int i = 0; i < countEven; i++)
			{
				result[i] = output[length];
				length--;
			}

			if (output.Sum() == 0)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Console.WriteLine("[" + string.Join(", ", result) + "]");
			}
		}

		private static void LastOdd(int[] input, int count)
		{
			int countOdd = 0;
			int[] output = new int[count];

			for (int i = input.Length - 1; i >= 0; i--)
			{
				if (countOdd >= count)
				{
					break;
				}
				else
				{
					if (input[i] % 2 != 0)
					{
						output[countOdd] = input[i];
						countOdd++;
					}
				}
			}

			int[] result = new int[countOdd];
			int length = countOdd - 1;

			for (int i = 0; i < countOdd; i++)
			{
				result[i] = output[length];
				length--;
			}

			if (output.Sum() == 0)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Console.WriteLine("[" + string.Join(", ", result) + "]");
			}
		}
	}
}