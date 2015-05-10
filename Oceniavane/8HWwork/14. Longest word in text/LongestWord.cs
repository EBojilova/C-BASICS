using System;
using System.Collections.Generic;
using System.Linq;

class LongestWord
{
	static void Main()
	{
		string text = Console.ReadLine();
		string[] words = text.Split(' ');
		string longestword = words[0];

		for (int i = 0; i < words.Length; i++)
		{
			if (longestword.Length < words[i].Length){
				longestword = words[i];
			}
		}
		Console.WriteLine(longestword);

	}
}