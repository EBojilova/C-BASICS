﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), "*");
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', n / 2 - 1 - i), new string('*', 3 + i * 2));
        }
        Console.WriteLine(new string('*', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", "|", new string('*', n - 2));
        }
    }
}