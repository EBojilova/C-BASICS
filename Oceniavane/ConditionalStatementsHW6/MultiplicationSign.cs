using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 || a > 0 && b < 0 && c < 0 || a < 0 && b > 0 && c < 0 || a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result: + ");
            }
            else if (a < 0 && b > 0 && c > 0 || a < 0 && b < 0 && c < 0 || a > 0 && b < 0 && c > 0 || a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("Result: - ");
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
