using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', n+n/2));
        for (int i = 0; i < n/2+2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (n*3-(1+2*i)-2)/2), new string('.',1+2*i));
        }
        for (int i = 0; i < n/2-1; i++)
        {
           Console.WriteLine("{0}*{1}*{0}", new string('.', n-4-2*i), new string('.',n+6+4*i)); 
        }
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', (n - 2)), new string('.', n ));
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', ( n - 4 - 2 * i) ), new string('.', 1 + 2 * i), new string('.', n));
        }
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n-1-i), new string('.',n+2*i));
        }
        Console.WriteLine(new string('*', 3*n));
    }
}
