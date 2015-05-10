using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("height:");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = (a + b) / 2 * height;
        Console.WriteLine(area);
        Console.WriteLine();
    }
}

