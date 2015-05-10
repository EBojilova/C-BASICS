using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger nPow2Factorial = 1;
        BigInteger nPlus1FActorial = 1;
        BigInteger factorialN = 1;

        for (int i = 1; i <= n * 2; i++)
        {
            nPow2Factorial *= i;
        }

        for (int i = 1; i <= n + 1; i++)
        {
            nPlus1FActorial *= i;
        }

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }

        BigInteger result = nPow2Factorial / (nPlus1FActorial * factorialN);
        Console.WriteLine(result);
    }
}