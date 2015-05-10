using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("The biggest of 3 numbers is: " + a);
            }
            else if (a < b && b > c)
            {
                Console.WriteLine("The biggest of 3 numbers is: " + b);
            }
            else
            {
                Console.WriteLine("The biggest of 3 numbers is: " + c);

            }
        }
    }
}
