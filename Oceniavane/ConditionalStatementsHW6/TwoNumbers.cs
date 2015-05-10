using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TwoNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Result: {0} {1} ", b, a);
            }
            else
            {
                Console.WriteLine("Rsult: {0} {1} ", a, b);
            }
               
            

            
        }
    }
}
