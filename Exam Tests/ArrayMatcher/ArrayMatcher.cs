using System;
using System.Collections.Generic;
using System.Linq;

class ArrayMatcher
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split('\\');
        char[] first = input[0].ToCharArray();
        char[] second = input[1].ToCharArray();
        string command = input[2];

        List<char> newArray = new List<char>();
        if (command == "join")
        {
            newArray = first.Intersect(second).ToList();
        }
        else if (command == "right exclude")
        {
            ExcludeTheNext(first, second, newArray);
        }
        else if (command == "left exclude")
        {
            ExcludeTheNext(second, first, newArray);
        }
        newArray.Sort();
        Console.WriteLine(string.Join("", newArray));
    }

    private static void ExcludeTheNext(char[] first, char[] second, List<char> newArray)
    {
        newArray.AddRange(first);
        newArray.RemoveAll(item => second.Contains(item));
    }
}
