using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class PetersGame
{
    static void Main(string[] args)
    {
        ulong start = ulong.Parse(Console.ReadLine());
        ulong end = ulong.Parse(Console.ReadLine());
        string word = Console.ReadLine();
        BigInteger sum = 0;
        for (ulong i = start; i < end; i++)
        {
            if (i%5==0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }
        var sumSymbols = sum.ToString();
        if (sum % 2 ==0)
        {
            var first = sum.ToString().ToCharArray().First();
            sumSymbols = sumSymbols.Replace(first.ToString(), word);

        }
        else
        {
            var last = sum.ToString().ToCharArray().Last();
            sumSymbols = sumSymbols.Replace(last.ToString(), word);
        }
        Console.WriteLine(sumSymbols);
    }
}
