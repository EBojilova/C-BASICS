using System;

static class Fibonacci
{
	static void Main()
	{
		Console.Write("Write a number to generate a Fibonacci sequence: ");
		int n = int.Parse(Console.ReadLine());
		
		Console.WriteLine(Fib(n));
	}

	static double Fib(int n)
	{
		double a = 0;
		double b = 1;

		for (int i = 0; i < n; i++)
		{
			double temp = a;
			a = b;
			b = temp + b;
		}
		return b;
	}
}