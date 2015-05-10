using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_The_Biggest_of_3_Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            //input validation
            bool convert = false;
            while (!convert)
            {
                Console.Write("Enter a: ");
                convert = double.TryParse(Console.ReadLine(), out a);
                if (!convert)
                {
                    Console.Write("Error! ");
                }
            }

            convert = false;
            while (!convert)
            {
                Console.Write("Enter b: ");
                convert = double.TryParse(Console.ReadLine(), out b);
                if (!convert)
                {
                    Console.Write("Error! ");
                }
            }

            convert = false;
            while (!convert)
            {
                Console.Write("Enter c: ");
                convert = double.TryParse(Console.ReadLine(), out c);
                if (!convert)
                {
                    Console.Write("Error! ");
                }
            }
            //end of input validation

            double max;
            if (a > b)
            {
                max = a;
                if (c > a)
                {
                    max = c;
                }
            }
            else // a < b
            {
                max = b;
                if (c > b)
                {
                    max = c;
                }
            }
            Console.WriteLine("The biggest number is: " + max);
        }
    }
}
