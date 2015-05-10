using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        Console.Write("Please enter x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5);
        Console.WriteLine(inCircle);
        bool inRectangle = (-1 <= x && x <= 5 && -1 <= y && y <= 1);
        bool outRectangle = !inRectangle;
        Console.WriteLine(outRectangle);
        Console.WriteLine(inCircle && outRectangle ? "yes" : "no");
    }
}

