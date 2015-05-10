using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        int n, row, col = new int();
        int nTemp = 1;
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (!int.TryParse(nStr, out n) || n <= 0 || n >= 21)
        {
            Console.WriteLine("out of range");
            return;
        }
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n/2; i++)
        {
            for (col = 0+i, row = 0+i; col < n-i; col++)
            {
                matrix[row, col] = nTemp;
                nTemp++;
            }
            for (col = n - 1-i, row = 1+i; row < n-i; row++)
            {
                matrix[row, col] = nTemp;
                nTemp++;
            }
            for (col = n - 2-i, row = n - 1-i; col >= 0+i; col--)
            {
                matrix[row, col] = nTemp;
                nTemp++;
            }
            for (col = 0+i, row = n - 2-i; row >= 1+i; row--)
            {
                matrix[row, col] = nTemp;
                nTemp++;
            }
        }
        if (n%2==1)
        {
            matrix[n/2, n/2] = n*n;
        }
        for (row = 0; row < n; row++)
        {
            for (col = 0; col < n; col++)
            {
                if (nTemp < 10)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                else if (10<=nTemp && nTemp<100)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }

            }
            Console.WriteLine();
        }
    }
}

