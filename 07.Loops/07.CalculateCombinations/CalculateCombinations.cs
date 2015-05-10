using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main()
    {
        int n, k = new int();
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        BigInteger factorielNK = 1;
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (int.TryParse(nStr, out n)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("k(k<n): ");
        string kStr = Console.ReadLine();
        if (int.TryParse(kStr, out k)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
            if (i <= k)
            {
                factorielK *= i;
            }
            if (i <= n-k)
            {
                factorielNK *=i;
            }
        }
        BigInteger combinations = factorielN / (factorielK * factorielNK);
        Console.WriteLine("{0}", combinations);
    }
}

