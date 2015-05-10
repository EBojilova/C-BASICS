using System;

class Sunglasses
{
    static void Main(string[] args)
    {
        ushort n = ushort.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string((i == (n-2) / 2 ? '|' : ' '), n));
        }
        Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
    }
}
