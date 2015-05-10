using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        int a = 0;
        int b = 1;
        int c;

        if (n >= 3)
        {
            Console.Write(a + " " + b + " ");
            for (int i = 0; i < n - 2; i++)
            {
                c = a;
                a = b;
                b = a + c;
                Console.Write(b + " ");
            }
            Console.WriteLine();
        }
        else if (n == 2)
        {
            Console.WriteLine(a+" "+b);
        }
        else if (n == 1)
        {
            Console.WriteLine(a);
        }
    }
}