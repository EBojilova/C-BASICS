using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string stringToCheck = "http://";
            string stringToCheck2 = "www.";
            foreach (string x in input)
            {
                if (x.Contains(stringToCheck) || x.Contains(stringToCheck2))
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}

/*Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
		string rawString = Console.ReadLine();
		foreach (Match m in linkParser.Matches(rawString))
		{
			Console.WriteLine(m);
		}*/