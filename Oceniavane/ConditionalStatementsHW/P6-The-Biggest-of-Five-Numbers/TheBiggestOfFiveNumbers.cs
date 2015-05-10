using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_The_Biggest_of_Five_Numbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double a = 0, max = double.MinValue;
            //input validation

            for (int i = 0; i < 5; i++)
            {
                bool convert = false;
                while (!convert)
                {
                    Console.Write("Enter number {0} : ",(i+1));
                    convert = double.TryParse(Console.ReadLine(), out a);
                    if (!convert)
                    {
                        Console.Write("Error! ");
                    }
                }

                if (a > max)
                {
                    max = a;
                }
            }
            Console.WriteLine("The biggest number is: " + max);
        }
    }
}
