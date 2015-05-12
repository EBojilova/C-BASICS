using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            decimal result = 1;
            for (int i = 0; i < m; i++)
            {
                result *= n;
            }
            Console.WriteLine("n^m = " + result);
        }
    }
}
