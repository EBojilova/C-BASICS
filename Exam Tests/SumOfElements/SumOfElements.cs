using System;
using System.Collections.Generic;
using System.Linq;

class SumOfElements
{
    static void Main(string[] args)
    {
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => long.Parse(s));
        long sum = numbers.Sum();
        long max = numbers.Max();
        long check = sum - max;
        if (max == check)
        {
            Console.WriteLine("Yes, sum={0}", max);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(max - check));
        }
    }
}
