using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace _12.CountingWordInText
{
    class CountingWordInText
    {
        static void Main(string[] args)
        {
           Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string select = Console.ReadLine().ToLower();
            string stringInput = Console.ReadLine().ToLower();
            foreach (var symbol in stringInput)
            {
                if (!Char.IsLetter(symbol))
                {
                    stringInput = stringInput.Replace(symbol, ' ');
                }
            }
            string[] input = stringInput.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            int count = input.Count(w => w == select);
            Console.WriteLine(count);
        }
    }
}
