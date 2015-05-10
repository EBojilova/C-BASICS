using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Exchange_if_Greater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
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

            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
