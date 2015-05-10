using System;
using System.Collections.Generic;

class PrimesInRangeProblem
{
	static List<int> PrimesInRange = new List<int>();

	static void Main()
	{
		Console.Write("Enter starting number: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Enter Ending Number: ");
		int b = int.Parse(Console.ReadLine());

		if (a < b)
		{
			FindPrimesInRange(a, b);
			ListPrimes();
		}
		else
		{ 
			Console.WriteLine("(empty list)");
		}
	}

	static void FindPrimesInRange(int a, int b)
	{
		int k = 0;
		if (a == 0)
		{
			a = 1;
		}

		for (int i = a; i <= b; i++)
		{
			k = 0;

			for (int j = 1; j <= i; j++)
			{
				if (i % j == 0)
				{
					k++;
				}
			}

			if (k == 2)
			{
				PrimesInRange.Add(i);
			}
		}
	}
	static void ListPrimes()
	{
		for (int i = 0; i < PrimesInRange.Count - 1; i++)
		{
			Console.Write(PrimesInRange[i] + ", ");
		}
		Console.WriteLine(PrimesInRange[PrimesInRange.Count - 1]);
	}
}