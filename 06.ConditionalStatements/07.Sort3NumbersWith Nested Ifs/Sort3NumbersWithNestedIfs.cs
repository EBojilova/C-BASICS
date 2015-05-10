using System;

class Sort3NumbersWithNestedIfs
{
    static void Main(string[] args)
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
        Console.Write("c: ");
        string cStr = Console.ReadLine();
        if (double.TryParse(cStr, out c)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        if (a >= b & a >= c)
        {
            if (b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (c >= b)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }

        }
        else if (b >= a & b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else if (c >= a)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        else if (c >= a & c >= b)
        {
            if (a >= b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else if (b >= a)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}

