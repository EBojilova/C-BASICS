using System;

static class Program
{
	static void Main()
	{
		Console.Write("Enter number: ");
		long n = long.Parse(Console.ReadLine());
		Console.WriteLine(isPrime(n));
	}

	static bool isPrime(long n)
	{
		long k = 0;

		for (long i = 1; i <= n; i++)
		{
			if (n % i == 0)
			{
				k++;
			}
		}

		if (k == 2)
		{
			return true;
		}
		else
		{
			return false;
		}

	}
}