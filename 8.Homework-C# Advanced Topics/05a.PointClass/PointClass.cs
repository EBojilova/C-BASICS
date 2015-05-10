using System;

class PointClass
{
    static void Main(string[] args)
    {
        Point a = new Point() { X = 20, Y = 30 };
        Console.WriteLine("Point({0}, {1})", a.X, a.Y);
        Point b = new Point() { X = 0, Y = 100 };
        Console.WriteLine("Point({0}, {1})", b.X, b.Y);
    }
}

