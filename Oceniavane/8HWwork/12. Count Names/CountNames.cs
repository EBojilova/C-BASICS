using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The 
//letters should be listed in alphabetical order. Use the input and output format from the examples below. Examples:


class CountNames
{
	static void Main()
	{
		Console.WriteLine("Please enter a list of names separated by a space");
		string input = Console.ReadLine();
		
		List<string> inputList = input.Split(' ').ToList();
		List<string> ModifyMe = input.Split(' ').ToList();

		inputList.Sort();
		ModifyMe.Sort();

		foreach (string name in inputList)
		{
			int count = 0;

			for (int i = 0; i <= ModifyMe.Count(); i++)
			{
				if (ModifyMe.Contains(name))
				{
					count++;
					ModifyMe.Remove(name);
				}
			}
			
			if (count != 0)
			{
				Console.Write(name + "-> " + count + "\n");
			}
		}
	}
}
