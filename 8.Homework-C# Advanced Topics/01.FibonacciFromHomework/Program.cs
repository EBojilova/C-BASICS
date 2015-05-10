using System;

class FibonacciNumbers
{
    static uint Fib(int n)
    {
        uint f1 = 1, f2 = 1;
        int i;

        for (i = 0; i < n; ++i)
        {
            if (i % 2 == 0)
            {
                f1 += f2;
            }
            else
            {
                f2 += f1;
            }
        }

        if (i % 2 == 0)
        {
            return f1;
        }
        else
        {
            return f2;
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Fib({0}) = {1}", n, Fib(n));
    }
}