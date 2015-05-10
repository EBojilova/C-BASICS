using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c = new double();
        Console.Write("Enter a: ");
        string aStr = Console.ReadLine();
        if (!double.TryParse(aStr, out a))
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("Enter b: ");
        string bStr = Console.ReadLine();
        if (!double.TryParse(bStr, out b))
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("Enter c: ");
        string cStr = Console.ReadLine();
        if (!double.TryParse(cStr, out c)) 
        {
            Console.WriteLine("out of range");
            return;
        }
        double d = b * b - 4 * a * c;
        if (d == 0)
        {
            Console.WriteLine("x1=x2={0}", (-b) / (2 * a));
        }
        else if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            double x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("x1={0}; x2={1}", x1, x2);
        }
    }
}
