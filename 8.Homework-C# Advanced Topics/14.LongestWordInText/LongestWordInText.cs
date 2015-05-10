using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.LongestWordInText
{
    class LongestWordInText
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string longest = input.OrderByDescending(s => s.Length).First();
            Console.WriteLine(longest);
        }
    }
}
