using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07SumOf5Numbers
{
    class Problem07SumOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a five numbers separeted by space:");
            string[] userINput = Console.ReadLine().Split(' ');
            double a = double.Parse(userINput[0]);
            double b = double.Parse(userINput[1]);
            double c = double.Parse(userINput[2]);
            double d = double.Parse(userINput[3]);
            double e = double.Parse(userINput[4]);

            Console.WriteLine("The sum of these numbers is " +(a+b+c+d+e));
        }
    }
}
