using System;

class MinMaxSumAverageNnumbers
{
    static void Main()
    {
        double n, nI = new double();
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (double.TryParse(nStr, out n)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            Console.Write("num{0}: ", i);
            string nIstr = Console.ReadLine();
            if (double.TryParse(nIstr, out nI)) ;
            else
            {
                Console.WriteLine("out of range");
                return;
            }
            if (nI >= max) 
            {
                max = nI;
            }
            if (nI <= min)
            {
                min = nI;
            }
            sum += nI;
        }
        double average = sum / n;
        Console.WriteLine("min= {0}", min);
        Console.WriteLine("max= {0}", max);
        Console.WriteLine("sum= {0}", sum);
        Console.WriteLine("avg= {0:F2}", average);
    }
}

