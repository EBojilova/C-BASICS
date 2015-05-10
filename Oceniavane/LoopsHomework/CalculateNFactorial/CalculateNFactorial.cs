using System;
using System.Numerics;



class CalculateNFactorial
{
    static void Main()
    {
        Console.WriteLine("Please enter \"n\" and \"k\":");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFac = 1;
        BigInteger kFac = 1;
        int nKSub = n - k;
        BigInteger nKfac = 1;
        if (n < 100 && n >= k && n > 1 && k > 1)
        {
            for (int i = 1; i <= n; i++)
            {
                nFac *= i;
                if (i <= k)
                {
                    kFac *= i;
                }

            }
            for (int i = 1; i <= nKSub; i++)
            {
                nKfac *= i;
            }
            Console.WriteLine(nFac / (kFac * nKfac));
        }

        else
        {
            Console.WriteLine("Wrong input!");
        }
    }

}


