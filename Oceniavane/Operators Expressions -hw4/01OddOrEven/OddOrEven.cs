using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) {
                Console.WriteLine("Your number is even");
            }
            else { Console.WriteLine("Your number is odd");
            }

        }
    }
}
