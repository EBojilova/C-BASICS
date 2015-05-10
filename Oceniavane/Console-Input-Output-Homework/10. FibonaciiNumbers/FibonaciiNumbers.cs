using System;

class FibonaciiNumbers
{
    static void Main()
    {
        Console.Write("How many Fibonacii numbers do you want to see :) ");
        int input = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c = 0;
        Console.Write("{0} {1} ", a, b);
        for (int i = 2; i < input; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}

