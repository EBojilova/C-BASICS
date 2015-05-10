using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountOfLetters
{
    class CountOfLetters
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Array.Sort(input);
            var groups = input.GroupBy(letter => letter);
            foreach (var group in groups)
            {
                Console.WriteLine("{0} -> {1} ", group.Key, group.Count());
            }
            Console.WriteLine();
        }
    }
}
