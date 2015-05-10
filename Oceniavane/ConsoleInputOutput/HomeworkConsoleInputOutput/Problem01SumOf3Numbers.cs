using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01SumOf3Numbers
{
    class Problem01SumOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter your c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of these numbers is " + (a + b + c));
        }
    }
}
