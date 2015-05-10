using System;

//Define a method Fib(n) that calculates the nth Fibonacci number;
// https://www.youtube.com/watch?v=UxICsjrdlJA&list=PL2_aWCzGMAwLz3g66WrxFGSXvSsvyfzCO&index=5

class FibNums
{
    private static int[] F = new int[51];

    static int Fib(int n) {
        if (n <= 1)
            return n;
        if (F[n] != 0)
        {
            return F[n];
        }
        F[n] = Fib(n - 1) + Fib(n - 2);
        return F[n];
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Fib(40));
    }
}