using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class ExtractURL
{
	static void Main()
	{
		Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
		string rawString = Console.ReadLine();
		foreach (Match m in linkParser.Matches(rawString))
		{
			Console.WriteLine(m);
		}
	}
}
