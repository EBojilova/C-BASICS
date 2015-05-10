using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
	//Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the 
	//first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The 
	//input and output lists are given as integers, separated by a space, each list at a separate line. 
	//Examples:
	/*
	 
	  20 40 10 10 30 80 |Out: 10 20 25 30 40 80
	  25 20 40 30 10	|
	 
	*/


	static void Main()
	{
		Console.WriteLine("Please input some integers separated by a space.");
		string numbers_s = Console.ReadLine();
		Console.WriteLine("Please input some more integers which I will join into the first ones and sort them.");
		string numbersToAdd_s = Console.ReadLine();

		List<int> convertedNums = Array.ConvertAll(numbers_s.Split(' '), int.Parse).ToList();
		List<int> convertedNumsToAdd = Array.ConvertAll(numbersToAdd_s.Split(' '), int.Parse).ToList();
		//^ c# is fucking stupid but I didnt wanna use a million lines for one thing

		List<int> result = convertedNums;

		foreach (int num in convertedNumsToAdd)
		{
			if (!result.Contains(num))
			{
				result.Add(num);
			}
		}

		result.Sort();

		Console.WriteLine("Your numbers: ");
		foreach (int num in result)
		{
			Console.Write(num + " ");
		}
		Console.WriteLine();
	}
}