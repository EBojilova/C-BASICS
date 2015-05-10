using System;

class CirclePerimeterArea
{
    static void Main()
    {
        double r = new double();
        Console.Write("r: ");
        string rStr = Console.ReadLine();
        if (!double.TryParse(rStr, out r))
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.WriteLine("The perimeter is: {0:F2}", 2 * Math.PI * r);
        Console.WriteLine("The area is: {0:F2}", Math.PI * r * r);
    }
}

