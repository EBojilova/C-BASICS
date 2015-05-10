using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter n");
            int n = int.Parse(Console.ReadLine());
            int result = GetNthFibonacci_Ite(n);
            Console.WriteLine(result);
        }

        public static int GetNthFibonacci_Ite(int n)
        {
            int[] Fib = new int[n + 1];
            Fib[0] = 1;
            Fib[1] = 1;
            //Console.WriteLine("here");
            for (int i = 2; i <= n; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
                //Console.WriteLine("fib[{0}] = {1} + {2} = {3}", i, Fib[i-2], Fib[i-1], Fib[i]);
            }
            return Fib[n];
        }
    }
}
