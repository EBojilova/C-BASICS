using System;
using System.Collections.Generic;
using System.Linq;

class BiggestTriple
{
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int size = 3;
        var result = numbers.Select((x, i) => new { Key = i / size, Value = x }).GroupBy(x => x.Key, x => x.Value).OrderByDescending(a => a.Sum()).First(); 
        Console.WriteLine(string.Join(" ", result));
    }
}