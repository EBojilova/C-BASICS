using System;
using System.Numerics;

class TrailingZeroesNfactoriel
{
    static void Main()
    {
        //answers.yahoo.com/question/index?qid=20080704003448AAiKGiR
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        int trailingZero = 0;
        int check = n;
        do
        {
            check /= 5;
            trailingZero += check;
        }
        while (check > 1);   
        
        Console.WriteLine(trailingZero);
    }
}

