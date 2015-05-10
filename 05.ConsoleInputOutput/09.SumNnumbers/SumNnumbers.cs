using System;

class SumNnumbers
{
    static void Main()
    {
        double result = 0;
        double n, nI = new double();
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (!double.TryParse(nStr, out n)) 
        {
            Console.WriteLine("out of range");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            string nIString = Console.ReadLine();
            if (!double.TryParse(nIString, out nI))
            {
                Console.WriteLine("out of range");
                return;
            }
            result += nI;
        }
        Console.WriteLine("Sum: {0}", result);
    }
}

