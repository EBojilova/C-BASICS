﻿using System;
class RandomNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random r = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(r.Next(min, max + 1) + " ");
        }
    }
}
