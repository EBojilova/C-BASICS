using System;

class NFibonacciNumbers
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        int c;
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write("{0} ", c);
                a = b;
                b = c;
            }
        }
    }
}