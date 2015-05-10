using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main(string[] args)
    {
        long startNum = long.Parse(Console.ReadLine());
        long endNum = long.Parse(Console.ReadLine());
        List<long> PrimeInRange = PrimeList(startNum, endNum);
        if (PrimeInRange.Count == 0)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            string result = string.Join(", ", PrimeInRange); // (.NET 4.0 only)
            Console.WriteLine(result);
        }
    }

    public static List<long> PrimeList(long start, long finish)
    {
        List<long> PrimeNumbers = new List<long>();
        for (long j = start; j <= finish; j++)
        {
            int count = 0;
            for (int i = 1; i <= j; i++)
            {
                if (j % i == 0)
                {
                    count++;
                }
            }
            if ((count <= 2) && (j !=0) && (j !=1))
            {
                PrimeNumbers.Add(j);
            }
        }

        return PrimeNumbers;
    }
}
