using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03CirclePerimeterAndArea
{
    class Problem03CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = ((2 * Math.PI) * radius);
            double area = Math.PI * (radius * radius);

            Console.WriteLine("Perimeter = {0:F2}", perimeter);
            Console.WriteLine("Area = {0:F2}", area);
        }
    }
}
