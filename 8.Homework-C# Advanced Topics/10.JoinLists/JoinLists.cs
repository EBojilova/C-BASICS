using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {

        string[] input = Console.ReadLine().Split(' ');
            HashSet<int> inputNums = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                inputNums.Add(int.Parse(input[i]));
            }
            input = Console.ReadLine().Split(' ');
            HashSet<int> inputNums2 = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                inputNums2.Add(int.Parse(input[i]));
            }
            inputNums.UnionWith(inputNums2);
            //Declare a new Array object of int type
            int[] sorted= inputNums.ToArray();
            // Sort the array
            Array.Sort(sorted);
            // Clear hashset object
            inputNums.Clear();
            //Merge the array into hashset object with sort order
            inputNums.UnionWith(sorted);
            //Print the all items of the hashset object
            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
