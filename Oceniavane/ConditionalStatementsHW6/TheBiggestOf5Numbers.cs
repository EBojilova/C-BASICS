using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6TheBiggestOf5Numbers
{
    class TheBiggestOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("The biggest of 5 numbers is: " + a);
            }
            else if (a < b && b > c && b > d && b > e)
            {
                Console.WriteLine("The biggest of 5 numbers is: " + b);
            }
            else if (a < c && b < c && c > d && c > e)
            {
                Console.WriteLine("The biggest ot 5 numbers is: " + c);
            }
            else if (a < d && b < d && c < d && d > e)
            {
                Console.WriteLine("The biggest ot 5 numbers is: " + d);
            }
            else
            {
                Console.WriteLine("The biggest ot 5 numbers is: " + e);
            }
        }
    }
}
