using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The 
//letters should be listed in alphabetical order. Use the input and output format from the examples below. Examples:


class CountOfLetters
{
	static void Main()
	{
		Console.WriteLine("Please enter a list of integers separated by a space");
		string input = Console.ReadLine();

		List<char> letters = new List<char>();
		for (int i = 97; i <= 122; i++)
		{
			letters.Add((char)i);
		}

		List<char> inputList = Array.ConvertAll(input.Split(' '), char.Parse).ToList();
		inputList.Sort();

		foreach (char letter in letters)
		{
			int count = 0;

			for (int i = 0; i <= inputList.Count(); i++)
			{
				if (inputList.Contains(letter))
				{
					count++;
					inputList.Remove(letter);
				}
			}

			if (count != 0)
			{
				Console.Write(letter + "-> " + count + "\n");
			}
		}
	}
}
