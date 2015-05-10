using System;

class Sunlight
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int width=n*3;
        Console.WriteLine("{0}*{0}", new string('.', width/2 ));
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', 1 + i), new string('.', (width-(1 + i)*2-3)/2));
        }
        for (int i = 0; i < (width-3-2*(n-1))/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        Console.WriteLine(new string('*', width));
        for (int i = 0; i < (width-3-2*(n-1))/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        for (int i = n-2; i >= 0; i--)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', 1 + i), new string('.', (width - (1 + i) * 2 - 3) / 2));
        }
        Console.WriteLine("{0}*{0}", new string('.', width / 2));
    }
}
