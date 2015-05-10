using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

internal class QuadraticEquation
{
    static void Main()
    {
        double a;
        while (!double.TryParse(Console.ReadLine(), out a))
            Console.WriteLine("Invalid input!!!");
        double b;
        while (!double.TryParse(Console.ReadLine(), out b))
            Console.WriteLine("Invalid input!!!");
        double c;
        while (!double.TryParse(Console.ReadLine(), out c))
            Console.WriteLine("Invalid input!!!");
        double discriminant = b*b - 4*a*c;

        if (discriminant == 0)
        {
            double x1Andx2 = ((-b) + Math.Sqrt(discriminant))/(2*a);
            Console.WriteLine("x1 = x2 = {0}", x1Andx2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }

    }
}