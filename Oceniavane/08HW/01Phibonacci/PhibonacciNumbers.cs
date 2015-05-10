using System;

class FibonacciNumbers
{
    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());

        // Output
        Console.WriteLine(Fib(n));
    }
    static int Fib(int number)
    {
        int firstFib = 1;
        int secondFib = 0;
        int result = 0;
        for (int i = 0; i <= number; i++)
        {
            if (number == 0 || number == 1)
            {
                return firstFib;
            }
            else
            {
                result = firstFib + secondFib;
                firstFib = secondFib;
                secondFib = result;
            }
        }
        return result;
    }
}
