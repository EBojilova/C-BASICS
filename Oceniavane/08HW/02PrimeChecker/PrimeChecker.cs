using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            Console.Write("Num: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", IsItPrime(number));

        }
        static bool IsItPrime(double number)
        {
            bool IsPrime = true;
            int maxDivider = (int)Math.Sqrt(number);
            if (number == 0 || number == 1)
            {
                IsPrime = false;
                return IsPrime;
            }
            for (int i = 2; i <= maxDivider; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            return IsPrime;
        }
    }
}
