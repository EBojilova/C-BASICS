using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = new int();
            BigInteger factorielN = 1;
            BigInteger factorielN1 = 1;
            BigInteger factoriel2N = 1;
            Console.Write("n: ");
            string nStr = Console.ReadLine();
            if (int.TryParse(nStr, out n)) ;
            else
            {
                Console.WriteLine("out of range");
                return;
            }
            for (int i = 1; i <= 2*n; i++)
            {
                factoriel2N *= i;
                if (i <= n)
                {
                    factorielN *= i;
                }
                if (i <= n +1)
                {
                    factorielN1 *= i;
                }
            }
            BigInteger catalan = factoriel2N / (factorielN1 * factorielN);
            Console.WriteLine("{0}", catalan);
        }
    }

