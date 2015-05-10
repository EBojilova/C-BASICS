using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7Sort3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("Result: {0} {1} {2} ", a, b, c);
                }
                else
                {
                    Console.WriteLine("Result: {0} {1} {2} ", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("Result: {0} {1} {2} ", b, a, c);
                }
                else 
                {
                    Console.WriteLine("Result: {0} {1} {2} ", b, c, a);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("Result: {0} {1} {2} ", c, a, b);
                }
                else
                {
                    Console.WriteLine("Result: {0} {1} {2} ", c, b, a);
                }
            }
        }
    }
}
