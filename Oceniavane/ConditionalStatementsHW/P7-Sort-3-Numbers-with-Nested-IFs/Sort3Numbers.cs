using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_Sort_3_Numbers_with_Nested_IFs
{
    class Sort3Numbers
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

            double max1, max2, max3;
            if (a > b)
            {
                max1 = a;
                max2 = b;
                if (c > a)
                {
                    max1 = c;
                    max2 = a;
                    max3 = b;
                }
                else //c<a
                {
                    if (c > b)
                    {
                        max1 = a;
                        max2 = c;
                        max3 = b;
                    }
                    else //c<b
                    {
                        max1 = a;
                        max2 = b;
                        max3 = c;
                    }
                }
            }
            else //a<b
            {
                max1 = b;
                max2 = a;
                if (c > b)
                {
                    max1 = c;
                    max2 = b;
                    max3 = a;
                }
                else //c<b
                {
                    if (c > a)
                    {
                        max1 = b;
                        max2 = c;
                        max3 = a;
                    }
                    else //c<a
                    {
                        max1 = b;
                        max2 = a;
                        max3 = c;

                    }
                }
            }
            Console.WriteLine("{0} {1} {2}", max1, max2, max3);
        }
    }
}
