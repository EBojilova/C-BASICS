using System;

class SortingNumbers
{
	static void Main()
	{
		Console.WriteLine("Please input how many integers you are going to input.");
		int count = int.Parse(Console.ReadLine());

		Console.WriteLine("Please enter " + count + " integers.");
		int[] ints = new int[count];

		for (int i = 0; i < count; i++)
		{
			ints[i] = int.Parse(Console.ReadLine());
		}

		Console.WriteLine("\nAnd here are your integers, sorted:");
		Array.Sort(ints);
		foreach (var item in ints)
		{
			Console.WriteLine(item);
		}
	}
}
