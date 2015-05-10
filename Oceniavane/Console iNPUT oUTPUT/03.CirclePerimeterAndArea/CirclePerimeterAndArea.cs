using System;
using System.Globalization;
using System.Threading;

internal class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double r = double.Parse(Console.ReadLine());
        double perimeter = 2*Math.PI*r;
        double area =Math.PI * Math.Pow(r, 2);
        Console.WriteLine("{0:0.00}", perimeter);
        Console.WriteLine("{0:0.00}", area);
    }
}