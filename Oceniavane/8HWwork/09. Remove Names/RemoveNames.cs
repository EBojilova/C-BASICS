using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
	//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
	//The input and output lists are given as words, separated by a space, each list at a separate line.
	static void Main()
	{
		Console.WriteLine("Please input some names separated by a space.");
		string names_s = Console.ReadLine();
		Console.WriteLine("Please input the names you want to remove from the first list, separated by a space.");
		string namesToRemove_s = Console.ReadLine();

		List<string> names = new List<string>(names_s.Split(' ')).ToList();
		List<string> namesToRemove = new List<string>(namesToRemove_s.Split(' ')).ToList();
		
		List<string> result = names.Except(namesToRemove).ToList();

		Console.WriteLine("After: ");
		foreach (string name in result)
		{
			Console.Write(name + " ");
		}
		Console.WriteLine();
	}
}