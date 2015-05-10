using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double parameter = Math.PI * 2 * radius;
            double area = Math.PI * (radius * radius);
            Console.WriteLine("The area of the circle is: " + Math.Round(area, 2));
            Console.WriteLine("The parameter of the circle is: " + Math.Round(parameter, 2));
        }
    }

