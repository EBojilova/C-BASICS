using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] allNums= new int[n];
            for (int i = 0; i < n; i++)
            {
                allNums[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(allNums);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(allNums[i]);
            }
        }
    }
}
