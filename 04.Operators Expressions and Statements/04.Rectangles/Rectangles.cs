using System;

 class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Please enter with:");
            double width=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height:");
            double height = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            Console.WriteLine("The perimeter is: {0}", perimeter);
            Console.WriteLine("The area is: {0}", area);
        }
    }

