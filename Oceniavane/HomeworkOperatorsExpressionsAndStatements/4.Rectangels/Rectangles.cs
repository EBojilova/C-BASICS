using System;

class Rectangles
{
    static void Main()
    {
        //Random r = new Random();
        //double width = r.Next(1, 20);
        //double height = r.Next(1, 20);
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        double area = (width * height);
        Console.WriteLine("The width is {0}, " + "the height is {1}. " + "The perimeter is {2}, the area is {3}.",
                            width, height, perimeter, area);
    }
}

