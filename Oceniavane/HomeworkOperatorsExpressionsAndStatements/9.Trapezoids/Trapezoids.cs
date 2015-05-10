using System;
  class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter a base: ");
        double aBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b base: ");
        double bBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((aBase + bBase) / 2) * h;
        Console.WriteLine("The area is: {0}", area);
    }
}

