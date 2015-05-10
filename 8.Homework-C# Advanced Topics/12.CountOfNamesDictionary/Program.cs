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