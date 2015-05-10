/*
Define a method Fib(n) that calculates the nth Fibonacci number. Examples:
 
n	Fib(n)	   
0	1	   
1	1	   
2	2	   
3	3	   
4	5	   
5	8	   
6	13	   
11	144	   
25	121393	 
*/
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