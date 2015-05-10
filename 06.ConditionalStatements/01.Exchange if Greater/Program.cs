using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a, b, c = new double();
        Console.Write("a: ");
        string aStr = Console.ReadLine();
        if (double.TryParse(aStr, out a)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        Console.Write("b: ");
        string bStr = Console.ReadLine();
        if (double.TryParse(bStr, out b)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}