using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Please enter x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        bool inCircle = (x * x + y * y <= 2 * 2);
        Console.WriteLine(inCircle);
    }
}

