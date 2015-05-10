using System;

class CalculateFactorielAndDegreeDevision
{
    static void Main(string[] args)
    {
        int n, x = new int();
        long factoriel = 1;
        long degree = 1;
        double calculation = 1;
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (int.TryParse(nStr, out n)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("x: ");
        string xStr = Console.ReadLine();
        if (int.TryParse(xStr, out x)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            degree *= x;
            calculation += (double)factoriel / (double)degree;
        }
        Console.WriteLine("{0:F5}", calculation);
    }
}

