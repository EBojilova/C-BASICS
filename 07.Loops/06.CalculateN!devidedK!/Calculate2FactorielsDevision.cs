using System;
using System.Numerics;

class Calculate2FactorielsDevsion
{
    static void Main()
    {
        int n, k = new int();
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
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
            if (i<=k)
            {
                factorielK *= i;
            }
        }
        BigInteger calculation = factorielN/factorielK;
        Console.WriteLine("{0}", calculation);
    }
}

