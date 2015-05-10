using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Fib
    {
        static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonachi(n));
        }
        static int Fibonachi(int number)
        {
            int firstMember = 1;
            int secondMember = 0;
            int result = 0;
            for (int i = 0; i <= number; i++)
            {
                if (number == 0 || number == 1)
                {
                    return firstMember;
                }
                else
                {
                    result = firstMember + secondMember;
                    firstMember = secondMember;
                    secondMember = result;
                }
            }
            return result;
        }
    }
}
