using System;

class Program
{
    static double[] _lookup = new double[5];

    static void Main()
    {
        
        double a = Math.Sqrt(1);
        double b = Math.Sqrt(2);
        double c = Math.Sqrt(3);
        double d = Math.Sqrt(4);

      
        var lookup = _lookup;
        lookup[1] = a;
        lookup[2] = b;
        lookup[3] = c;
        lookup[4] = d;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);

        Console.WriteLine(lookup[1]);
        Console.WriteLine(lookup[2]);
        Console.WriteLine(lookup[3]);
        Console.WriteLine(lookup[4]);
    }
}