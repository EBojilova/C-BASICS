using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            List<string> newArray = new List<string>();
            newArray.AddRange(input1);
            newArray.RemoveAll(name => input2.Contains(name));
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
