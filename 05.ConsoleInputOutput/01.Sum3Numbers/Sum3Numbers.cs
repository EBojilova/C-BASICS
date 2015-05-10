using System;

class Sum3Numbers
{
    static void Main(string[] args)
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
        Console.WriteLine("a+b+c={0}", a + b + c);
    }
}
