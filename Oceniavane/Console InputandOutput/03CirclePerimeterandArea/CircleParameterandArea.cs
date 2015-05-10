using System;

class CircleParameterandArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("perimeter = {0:0.00}", perimeter);
        Console.WriteLine("area = {0:0.00}", area);
    }
}