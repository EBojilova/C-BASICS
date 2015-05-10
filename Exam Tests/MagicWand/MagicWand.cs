using System;

class MagicWand
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', (3*n+2-1) / 2));
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', ((3 * n + 2 - 2 - (1 + 2 * i)) / 2)), new string('.', 1 + 2 * i));
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n+2));
        for (int i = 0; i < n / 2 ; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i + 1), new string('.', 3 * n + 2 - 2 - 2 * (i + 1)));
        }
        for (int i = 0; i < n / 2 ; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', (3 * n + 2 - 4 - 2 * i - n-n)/2), new string('.', n/2), new string('.', i), new string('.', n));
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', n / 2 + 1), new string('.', n / 2), new string('.', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n ), new string('.', n ));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n+2));
    }
}
