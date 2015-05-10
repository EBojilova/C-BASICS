using System;

class MatrixNumbers
{
    static void Main()
    {
        int n = new int();
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (int.TryParse(nStr, out n)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        int k = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0 + k; j < n + k; j++)
            {
                if (n<5)
                {
                    Console.Write("{0} ", j);
                }
                else
                {
                    Console.Write("{0,2} ", j);
                }
            }
            Console.WriteLine();
            k++;
        }
    }
}

