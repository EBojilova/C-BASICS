using System;

class MultiplicationSign
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
        Console.Write("c: ");
        string cStr = Console.ReadLine();
        if (double.TryParse(cStr, out c)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        if (a == 0 | b == 0 | c == 0)
        {
            Console.WriteLine("0");
        }
        else if (a < 0 & b < 0 & c < 0)
        {
            Console.WriteLine("-");
        }
        else if (a > 0 & b > 0 & c > 0)
        {
            Console.WriteLine("+");
        }
        else if (a < 0 & b > 0 & c > 0)
        {
            Console.WriteLine("-");
        }
        else if (a < 0 & b < 0 & c > 0)
        {
            Console.WriteLine("+");
        }
        else if (a < 0 & b > 0 & c < 0)
        {
            Console.WriteLine("+");
        }
        else if (a > 0 & b < 0 & c > 0)
        {
            Console.WriteLine("-");
        }
        else if (a > 0 & b < 0 & c < 0)
        {
            Console.WriteLine("+");
        }
        else if (a > 0 & b > 0 & c < 0)
        {
            Console.WriteLine("-");
        }
    }
}

