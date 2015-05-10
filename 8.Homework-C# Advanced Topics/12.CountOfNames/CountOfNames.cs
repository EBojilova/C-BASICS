using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Array.Sort(input);
            var groups = input.GroupBy(name => name);
            foreach (var group in groups)
            {
                Console.WriteLine("{0} -> {1} ", group.Key, group.Count());
            }
            Console.WriteLine();
        }
    }
}
