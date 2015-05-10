using System;
class CalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;

        int max = Math.Max(n, k);


        for (int i = 1; i <= max; i++)
        {
            if (i <= n)
            {
                factorialN *= i;
            }
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        Console.WriteLine(factorialN / factorialK);
    
    }
}