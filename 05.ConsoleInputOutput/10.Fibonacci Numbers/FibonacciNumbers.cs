using System;

class FibonacciNumbers
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        int c = new int();
        int n = new int();
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (int.TryParse(nStr, out n))
        {
            if (n == 0)
            {
                Console.WriteLine("");
            }
            else if (n == 1)
            {
                Console.WriteLine("{0} ", a);
            }
            else
            {
                Console.Write("{0} {1} ", a, b);
                for (int i = 0; i < n - 2; i++)
                {
                    c = a + b;
                    Console.Write("{0} ", c);
                    a = b;
                    b = c;
                }
            }
        }
        else
        {
            Console.WriteLine("out of range");
            return;
        }

    }
}

