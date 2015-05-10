/*
Write a program that reads a list of letters and prints for each letter
how many times it appears in the list. The letters should be listed
in alphabetical order. Use the input and output format from the examples below. Examples:

Input									Output
b b a a b								a -> 2
										b -> 3

h d h a a a s d f d a d j d s h a a		a -> 6
										d -> 5
										f -> 1
										h -> 3
										j -> 1
										s -> 2
*/
using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (string letter in input)
        {
            if (!dictionary.ContainsKey(letter))
            {
                dictionary[letter] = 0;
            }
            dictionary[letter] += 1;
        }

        List<string> sortedKeys = dictionary.Keys.ToList();
        sortedKeys.Sort();

        foreach (string key in sortedKeys)
        {
            Console.WriteLine("{0} -> {1}", key, dictionary[key]);
        }
    }
}