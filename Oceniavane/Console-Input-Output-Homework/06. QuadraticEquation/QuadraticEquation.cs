using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        double formulaX1 = ((-b) - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
        double formulaX2 = ((-b) + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
        Console.WriteLine("The value of x1 is: " + formulaX1);
        Console.WriteLine("The value of x2 is: " + formulaX2);
    }
}
